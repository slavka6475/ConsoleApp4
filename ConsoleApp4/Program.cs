//task1

//for (int i = 0; i <= 0; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//for (int i = 0; i <= 5; i++)
//{
//    for (int d = 0; d <= 0; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//task1 q2

//for (int i = 0; i <= 0; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//for (int i = 0; i <= 5; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//       Console.Write(" ");
//        if (d == 5-1)
//        {
//            Console.Write("#");
//        }
//    }

//     Console.WriteLine("");
//}

//task1 q3

//for (int i = 0; i <= 5; i++)
//{
//    for (int d = 0; d <= 0; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//for (int i = 0; i <= 0; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//task1 q4



//for (int i = 0; i <= 5; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//        Console.Write(" ");
//        if (d == 5 - 1)
//        {
//            Console.Write("#");
//        }
//    }

//    Console.WriteLine("");
//}

//for (int i = 0; i <= 0; i++)
//{
//    for (int d = 0; d <= 5; d++)
//    {
//        Console.Write("#");
//    }

//    Console.WriteLine("");
//}

//task2



{

    //    for (int a = 0; a <= 0; a++)
    //    {
    //        for (int d = 0; d <= 6; d++)
    //        {
    //            Console.Write("#");
    //        }

    //        Console.WriteLine("");
    //    }

    //    for (int i = 0; i <= 5; i++)
    //    {
    //        for (int d = 0; d <= 5; d++)
    //        {
    //            if (d == 0 || d == 5)
    //            {
    //                Console.Write("#");
    //            }
    //            Console.Write(" ");
    //        }
    //        Console.WriteLine("");
    //    }
    //}


    //for (int a = 0; a <= 0; a++)
    //{
    //    for (int d = 0; d <= 6; d++)
    //    {
    //        Console.Write("#");
    //    }

    //    Console.WriteLine("");
    //}

    //ефыл3 

    //int c = 0;

    //int d = 4;
    //for (int a = 0; a <= 5; a++)
    //{
    //    for (int i = 0; i <= d; i++)
    //    { 
    //        Console.Write(c);
    //        c += 1;

    //     }
    //    Console.WriteLine();
    //    c = 0;
    //    d -= 1;
    //}
    //ефыл4
    int s = 0;

    for (int d = 1; d <= 6; d++)
    {
        for (int i = 1; i <= 72; i++)
        {

            if (i == s)
            {
                Console.Write("2");
            }
            else
            {
                s += 2;
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        s = 0;
    }

}