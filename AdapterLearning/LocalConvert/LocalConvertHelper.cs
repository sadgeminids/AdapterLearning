using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    public class GameSourceClass
    {
        public int Hp;
        public int Mp;
        public int Attack;
    }  

    public class GameTargetClass
    {
        public int Attack;
    }

    public class LocalConvertHelper
    {
        public static GameTargetClass ConvertSourceToTarget(GameSourceClass sc)
        {
            GameTargetClass tc = new GameTargetClass();
            tc.Attack = sc.Attack;
            return tc;
        }
    }
}
