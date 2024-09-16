using UnityEngine;


namespace SOSXR.AdditionalGizmos
{
    public class DrawGizmoLineBetweenTransforms : DrawGizmosBase
    {
        [SerializeField] private Transform m_endTransform;

        [SerializeField] private bool m_onlyDrawWhenEndTransformSet = true;

        public Transform EndTransform
        {
            get => m_endTransform;
            set => m_endTransform = value;
        }


        protected override void SetGizmoDetails()
        {
            if (!EndTransform && m_onlyDrawWhenEndTransformSet)
            {
                return;
            }

            if (!EndTransform)
            {
                Debug.LogWarning("Cannot draw gizmos, since end is null!");

                return;
            }

            Gizmos.DrawLine(m_startTransform.position, EndTransform.position);
        }
    }
}