using System;

namespace AnonymousTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Anonymous anonymous = new Anonymous();

            dynamic anonymousDynamicData = anonymous.getData();
            Console.WriteLine(
                string.Format("{0} {1}",
                anonymousDynamicData.Name,
                anonymousDynamicData.EmailID)
            );

            object obj = anonymous.getData();
            Console.WriteLine(
                string.Format("{0} {1}",
                    ((dynamic)obj).Name,
                    ((dynamic)obj).EmailID)
            );
        }
        public object getData()
        {
            return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
        }

        class Anonymous
        {
            public object getData()
            {
                return new { Name = "Pepe", EmailID = "pepe@gmail.com" };
            }
        }

    }

}
