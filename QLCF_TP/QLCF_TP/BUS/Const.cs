using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_TP.BUS
{
    public class Const
    {
        private Random random = new Random();
        private static Const i;

        public static Const I {
            get { if (i == null) i = new Const(); return Const.i; }
            set => i = value;
        }
        private Const() {}
        public int TableWidth = 105;
        public int TableHeight = 105;
        public int PaddingMenu = 20;
        public int PaddCategory = 15;
        public int CategoryH = 100;
        public int CategoryW = 190;
        public Color CategoryBG1 = Color.LightCyan;
        public Color CategoryBG2 = Color.LightSalmon;
        public int MenuH = 100;
        public int MenuW = 200;
    }
}
