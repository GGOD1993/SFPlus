using System;
using UnityEngine;

namespace GameMain
{
    [Serializable]
    public abstract class TargetableObjectData : EntityData
    {
        [SerializeField]
        private CampType m_Camp = CampType.Unknown;

        [SerializeField]
        private int m_HP = 0;

        public TargetableObjectData(int entityId, int typeId, CampType camp)
            :base(entityId, typeId)
        {
            m_Camp = camp;
            m_HP = 0;
        }

        public CampType Camp
        {
            get
            {
                return m_Camp;
            }
        }

        public int HP
        {
            get
            {
                return m_HP;
            }
            set
            {
                m_HP = value;
            }
        }

        public abstract int MaxHP
        {
            get;
        }

        public float HPRatio
        {
            get
            {
                return MaxHP > 0 ? (float)HP / MaxHP : 0f;
            }
        }
    }
}