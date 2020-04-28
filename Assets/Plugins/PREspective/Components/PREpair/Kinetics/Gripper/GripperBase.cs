#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using System.Collections.Generic;
using System.Reflection;
using u040.prespective.prepair.inspector;
using u040.prespective.utility.editorscripts.customAttributes;
using UnityEngine;

namespace u040.prespective.prepair.physics.kinetics.gripper
{

    public class GripperBase : BaseGripperBase, IControlPanel
    {
        [SerializeField] private int toolbarTab;

        //Required components
        private GripperFinger mainFinger;
        private GripperFinger secondaryFinger;

        //Settings
        [ButtonAttribute("toggleGripperClose")] public bool ToggleGripper = false;
        [Range(0f, 1f)] public float CloseFactor = 0f;
        public float ClosingSpeed = 0.5f; //own length/sec
        public bool DEBUG = true;


        //Data
        [ReadOnly] public bool iClosed;

        protected override void initializeGripper()
        {
            base.initializeGripper();

            while (this.Fingers.Count < 2)
            {
                this.Fingers.Add(null);
            }
            this.mainFinger = (GripperFinger)this.Fingers[0];
            this.secondaryFinger = (GripperFinger)this.Fingers[1];
        }

        protected override void moveFingersInPosition(float _deltaTime)
        {
            if (!isInPosition())
            {
                float distanceFromMovePoint = (CloseFactor - mainFinger.prismaticJoint.CurrentPerc) * mainFinger.prismaticJoint.ConstrainingSpline.SplineLength; //Distance between current position and closeFactorpoint to move to
                int direction = Math.Sign(distanceFromMovePoint); //direction to move in
                float intendedMove = ClosingSpeed * mainFinger.prismaticJoint.ConstrainingSpline.SplineLength * _deltaTime * direction; //Calculated the inteded move step

                mainFinger.prismaticJoint.KinematicTranslation(Math.Abs(distanceFromMovePoint) > Math.Abs(intendedMove) ? intendedMove : distanceFromMovePoint, utility.VectorSpace.LocalParent, new Action<float, Vector3>((float percentage, Vector3 translation) => { /*Callback here*/ })); //apply step
            }
        }

        protected override void processGrip()
        {
            //If detected both same objects, not null, and not yet registered
            if ((mainFinger.DetectedObject == secondaryFinger.DetectedObject) && (mainFinger.DetectedObject != GrippedObject) && (mainFinger.DetectedObject != null))
            {
                CloseFactor = mainFinger.prismaticJoint.CurrentPerc;
                List<Vector3[]> _cols = new List<Vector3[]>() { mainFinger.TriggerCollisionPoints, secondaryFinger.TriggerCollisionPoints };

                GrippedObject = mainFinger.DetectedObject;
                RegisteredLocalPosition = transform.InverseTransformPoint(GrippedObject.transform.position); //Convert grippedObject worldspace to localspace point
                RegisteredRotation = Quaternion.Inverse(transform.rotation) * GrippedObject.transform.rotation;

                DBLog.Regular(this, "Gripped object: " + GrippedObject.name + ", registeredPosition: " + RegisteredLocalPosition.ToString(), DEBUG);

            }

            //If both claw do not detect the grippedObject anymore
            else if (mainFinger.DetectedObject != GrippedObject && secondaryFinger.DetectedObject != GrippedObject && GrippedObject != null)
            {
                DBLog.Regular(this, "Release", DEBUG);
                GrippedObject = null;
                RegisteredLocalPosition = transform.localPosition; //reset to own position
                RegisteredRotation = transform.localRotation;
            }

            //If claws touch
            else if ((mainFinger.DetectedObject == secondaryFinger.gameObject || secondaryFinger.DetectedObject == mainFinger.gameObject) && CloseFactor != 0)
            {
                DBLog.Warning(this, "Claws made contact. Opening gripper.");
                closeGripper(false);
            }

            setClosed(GrippedObject != null || (isInPosition() && CloseFactor == 1f));
        }

        bool isInPosition()
        {
            return CloseFactor >= (mainFinger.prismaticJoint.CurrentPerc - 0.001f) && CloseFactor <= (mainFinger.prismaticJoint.CurrentPerc + 0.001f); //Return true when distance between points is 0
        }


        public void toggleGripperClose()
        {
            closeGripper(!ToggleGripper);
        }

        public void closeGripper(bool state)
        {
            if (state != ToggleGripper)
            {
                ToggleGripper = state;
                CloseFactor = ToggleGripper ? 1 : 0;
                DBLog.Regular(this, ToggleGripper ? "Closing gripper" : "Opening gripper", DEBUG);
            }
        }
        
        void setClosed(bool _state)
        {
            if (iClosed != _state) iClosed = _state;
        }


        public void ShowControlPanel()
        {
#if UNITY_EDITOR || UNITY_EDITOR_BETA
            CloseFactor = EditorGUILayout.Slider("Close factor", CloseFactor, 0f, 1f);
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Toggle Gripper"))
            {
                toggleGripperClose();
            }
            GUILayout.EndHorizontal();
#endif
        }
    }
}