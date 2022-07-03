class Program
{
    

    static void Main()
    {


        int[,] r1 = new int[10, 10] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        Random rnd = new Random();
        

        
        int ship = 1;
        while (ship < 5)
        {
            int g = rnd.Next(0, 10);
            int g2 = rnd.Next(0, 10);

            if (r1[g, g2] == 0) 
            {
                r1[g, g2] = 1;

                ship++;
            }
            else
            {
                continue;
            }

            

        }
        //Ship 2

        int ship2 = 1;
        while (ship2 < 4)
        {
            int g = rnd.Next(0, 10);
            int g2 = rnd.Next(0, 10);

            if (r1[g, g2] == 0)
            {
                r1[g, g2] = 2;
                
                //ship2 [q] = [g, g2]; //попытка хороша

                
                

                ship2++;
            }
            else
            {
                continue;
            }
            foreach (int i in r1)
                if (i == 2)
                { 
                    for (int e = 1; e < r1.GetLength(1); e++)
                    {
                        if (e <= r1.GetLength(1))
                        {
                            //r1[g + e, g2] = 2;
                        }
                    }
                    r1[i + 11, g2] = 2;
                }
            //
            //for (int i = 1; i <r1.Get.Lenght(1); i++)
            //{
            //    if (i <= r1.GetLength(1))
            //    {
            //        r1[g + i, g2] = 2;
            //    }
            //}

            //
        }


        for (int i = 0; i < r1.GetLength(0); i++)
        {

            for (int j = 0; j < r1.GetLength(1); j++)
            {
                Console.Write($"{r1[i, j]} ");

                
            }
            Console.WriteLine();
        }

    }

}

        
