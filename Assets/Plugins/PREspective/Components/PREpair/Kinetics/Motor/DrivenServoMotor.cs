#if UNITY_EDITOR
using UnityEditor;
#endif
using u040.prespective.prepair.inspector;
using UnityEngine;

namespace u040.prespective.prepair.physics.kinetics.motor
{
    public class DrivenServoMotor : DrivenMotor, IControlPanel
    {
        public void ShowControlPanel()
        {
#if UNITY_EDITOR 
            PreferredVelocity = EditorGUILayout.Slider("Preferred Velocity (deg/s)", PreferredVelocity, 0f, MaxVelocity);
            TargetAngle = EditorGUILayout.DelayedFloatField("Target Angle (deg)", TargetAngle);
            Continuous = EditorGUILayout.Toggle("Continuous", Continuous);
            ContinuousDirection = (Direction)EditorGUILayout.EnumPopup("Continuous Direction", ContinuousDirection);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Velocity (deg/s)", Velocity.ToString());
            EditorGUILayout.LabelField("Position (deg)", Position.ToString());
            GUIStyle _labelStyle = new GUIStyle(GUI.skin.label);
            _labelStyle.normal.textColor = IsActive ? new Color(0f, 0.5f, 0f) : Color.red;
            _labelStyle.fontStyle = FontStyle.Bold;

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(!Application.isPlaying);
            EditorGUILayout.LabelField("State", IsActive ? "Active" : "Inactive", _labelStyle);
            if (GUILayout.Button(IsActive ? "Stop" : "Start"))
            {
                IsActive = !IsActive;
            }
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndHorizontal();
#endif
        }
    }
}