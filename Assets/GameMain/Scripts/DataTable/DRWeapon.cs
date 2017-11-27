using GameFramework.DataTable;
using System.Collections.Generic;

namespace GameMain
{
    public class DRWeapon : IDataRow
    {
        public int Id
        {
            get;
            private set;
        }

        public int Attack
        {
            get;
            private set;
        }

        public float AttackInterval
        {
            get;
            private set;
        }

        public int BulletId
        {
            get;
            private set;
        }

        public float BulletSpeed
        {
            get;
            private set;
        }

        public int BulletSoundId
        {
            get;
            private set;
        }

        public void ParseDataRow(string dataRowText)
        {
        }
    }
}