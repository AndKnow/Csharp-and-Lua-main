using System;
using System.Reflection;

namespace Params {
    class Program {
        static void Main() {
            // 矩形数组
            // int [2,3,4] ary1;//矩形数组的错误定义方式
            int [,] ary = new int [2,3] {{1,2,3},{4,5,6}};//长度是2*3,初始化的方式
            int[,] intArray2 = new int[,] { {10,1},{2,10},{11,9} };//另一种直接初始化

            // 交错数组
            // int [][] ary1 = new int[3][4];//交错数组错误的实例方式
            int [][] ary1 = new int[2][];
            ary1[0] = new int[1] {1};//必须要分开实例化
            ary1[1] = new int[3] {1, 2, 3};

            // 交错数组和矩形数组的交换
            int [][,] ary2 = new int[2][,];
            ary2[0] =  new int[,] {{1,2,3},{4,5,6}} ;
            ary2[1] =  new int[,] {{7,8,9},{4,5,6}} ;

            // foreach,不能修改值类型,但是引用类型的数组可以改变
            foreach(var x in ary) {  //对矩形数组来说,数据是连贯的
                Console.Write(x);
            } Console.WriteLine();

            // 矩阵数组的常规遍历
            for(int i = 0; i < intArray2.GetLength(0); i++) {
                for(int j = 0; j < intArray2.GetLength(1); j++)
                    Console.Write("{0} ",intArray2[i,j]);
                Console.WriteLine();
            }


            //交错数组的foreach遍历,对交错数组来说,数据是不连贯的
            foreach(var x in ary2) { 
                foreach(var y in x) {
                    Console.Write(y);
                } Console.Write('\n');
            }

            // 交错数组的常规遍历
            for(int i = 0; i < ary1.GetLength(0); i++) {
                for(int j = 0; j < ary1[i].GetLength(0); j++)
                    Console.Write("{0} ", ary1[i][j]);
                Console.WriteLine();
            }

        }
    }
}
