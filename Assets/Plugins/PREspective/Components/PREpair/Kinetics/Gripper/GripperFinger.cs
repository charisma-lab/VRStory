using u040.prespective.prepair.kinematics;
using UnityEngine;

namespace u040.prespective.prepair.physics.kinetics.gripper
{
    public class GripperFinger : BaseGripperFinger
    {
        //Required components
        public PrismaticJoint prismaticJoint;

        //Settings
        public bool DEBUG = false;

        protected override void autoDetectColliderAndTrigger() //Automatically detect all required components
        {
            bool _detectedAllComponents = true;
            #region<<PrismaticJoint>>

            prismaticJoint = this.RequireComponent<PrismaticJoint>(true);
            if (prismaticJoint == null) { _detectedAllComponents = false; }

            #endregion
            base.autoDetectColliderAndTrigger();
            #region<<Collider>>
            Collider[] col = GetComponentsInChildren<Collider>();
            if (col.Length > 2)
            {
                string jointNames = "";
                for (int i = 0; i < col.Length; i++)
                {
                    jointNames += col[i].name + (i < col.Length - 1 ? ", " : ".");
                }
                DBLog.Warning(this, "Cannot automatically detect 'Collider'. Multiple 'Collider' detected on: " + jointNames);
                _detectedAllComponents = false;
            }
            else if (col.Length == 2)
            {
                if (col[0].isTrigger != col[1].isTrigger)
                {
                    TriggerBox = col[0].isTrigger ? col[0] : col[1];
                    ColliderBox = col[0].isTrigger ? col[1] : col[0];
                }
                else
                {
                    string jointNames = "";
                    for (int i = 0; i < col.Length; i++)
                    {
                        jointNames += col[i].name + (i < col.Length - 1 ? ", " : ".");
                    }
                    DBLog.Warning(this, "Cannot automatically detect 'Collider'. Multiple 'Collider' detected on: " + jointNames);
                    _detectedAllComponents = false;
                }
            }
            else if (col.Length == 1)
            {
                if (col[0].isTrigger)
                {
                    TriggerBox = col[0];
                    DBLog.Warning(this, "Cannot automatically detect 'Collider'. No non-trigger collider detected.");
                    _detectedAllComponents = false;
                }
                else
                {
                    ColliderBox = col[0];
                    DBLog.Warning(this, "Cannot automatically detect 'Trigger'. No trigger collider detected.");
                    _detectedAllComponents = false;
                }
            }
            else
            {
                DBLog.Warning(this, "Cannot automatically detect 'Collider'. No 'Collider' detected.");
                _detectedAllComponents = false;
            }
            #endregion
            if (_detectedAllComponents) DBLog.Regular(this, "Automatically detected all components.", DEBUG);
        }

        protected override void onTriggerEnterInput(Collider _other)
        {
            base.onTriggerEnterInput(_other);
            DBLog.Regular(this, "Collider: " + DetectedObject.name, DEBUG);
        }

        protected override void onTriggerExitInput(Collider _other)
        {
            base.onTriggerExitInput(_other);
            if (DetectedObject != null) DBLog.Regular(this, "Released " + DetectedObject.name, DEBUG);
        }
    }
}