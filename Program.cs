class Program
{
    static void Main()
    {
        /**
          Для начала можно убрать твои 10 строк где ты ставишь 0.
          Если ты обьявляешь массив или матрицу из простых типов
          к примеру int то они по умолчанию уже = 0.
          r1 непонятное имя для поля, давай назовем 
        **/
        int[,] battleGround = new int[10, 10];

        /**
          Я бы назвал переменную random, не экономь места пиши длинные понятные названия
        **/
        Random random = new Random();
        
        // однопалубные
        int ship = 1;
        while (ship < 5)
        {
            int i = random.Next(0, 10);
            int j = random.Next(0, 10);

            if (battleGround[i, j] == 0) 
            {
                battleGround[i, j] = 1;
                ship++;
            }
            else
            {
                continue;
            }
        }

        //Двух палубные
        int ship2 = 1;
        while (ship2 < 4)
        {
            int i = random.Next(0, 10);
            int j = random.Next(0, 10);

            /**
                1. Найти свободную клетку
                2. Определить в какие 4 стороны будет корабль расти up, down, left, right
                3. Проверить влазит ли по координатам корабль в 2 клетки и не пересекается с другими кораблями
                4. Если влазит, то размещаем все палубы, иначе continue
            **/
            if (battleGround[i, j] == 0) //  1. Найти свободную клетку
            {
                /**
                  0 - up
                  1 - down
                  2 - left
                  3 - right
                **/
                // 2. Определить в какие 4 стороны будет корабль расти up, down, left, right
                int direction = random.Next(0, 4);
                if (direction == 0) // up
                {
                    //  3. Проверить влазит ли по координатам корабль в 2 клетки и не пересекается с другими кораблями
                    if (i - 1 >= 0 && battleGround[i - 1, j] == 0)
                    {

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (direction == 1) // down
                {
                    //  3. Проверить влазит ли по координатам корабль в 2 клетки и не пересекается с другими кораблями
                    if (i + 1 < 10 && battleGround[i + 1, j] == 0)
                    {

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (direction == 2) // left
                {
                    //  3. Проверить влазит ли по координатам корабль в 2 клетки и не пересекается с другими кораблями
                    if (j - 1 >= 0 && battleGround[i, j - 1] == 0)
                    {

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (direction == 3) // right
                {
                    //  3. Проверить влазит ли по координатам корабль в 2 клетки и не пересекается с другими кораблями
                    if (j + 1 < 10  && battleGround[i, j + 1] == 0)
                    {

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                continue;
            }
        }
        
        /**
          Для читабельности я вынес твой код по распечатке поля в отдельный метод.
          В метод передается матрица, которую надо распечатать
        **/
        printBattleGround(battleGround);
    }

    private static void printBattleGround(int [,] battleGround)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{battleGround[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}