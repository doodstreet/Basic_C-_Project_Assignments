using System;


namespace MethodOverloading_Assignment
{
    class DoMath
    {
        public int Math(int num)
        {
            return num * 11;
        }
        public decimal Math(decimal num )
        {
            return num + 3.14m;
        }
        public int Math(string num1)
        {
            int x = Convert.ToInt32(num1);
  
            return x / 10;



        }
         
    }
    
}
