using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCaculator03
{
    class MyData        //屬性是方法的變形
    {
        private int _x; //存取修飾詞= private(私有的)  *x/y欄位 /宣告個人金庫
        private int _y;

        public int X   //銀行行員       
        {
            get { return _x; }  //□=x (拿出來個人金庫的錢)-但是都必須透過銀行行員  
            set { _x = value; } //x=□ (存進去金庫的錢)-但是都必須透過銀行行員
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
