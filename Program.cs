using System;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //class
            User flower = new User();
            Number.ID1 = "Rose";
            Number.ID2 = "Sum Flower";
            Console.Write(Number.ID1);
            Console.Write(Number.ID2);

            //class_Rose
            ID_Rose1 = new ID_Rose;
            Plant_name1 = "ดอกกุหลาบสีขาว";
            Plant_description = "สวยงามมาก";
            Amount = 2;
            Height = 10.5;
            Circumference = 6;

            //class_Sun_Flower
            ID_Sun_Flower2 = new ID_Sun_Flower;
            Plant_name2 = "ดอกทานตะวันเล็ก";
            Plant_description = "สวยงาม";
            Amount = 1;
            Height = 2.0;
            Circumference = 2.0;

        }
    }
    class Roseflower
    {
        public int User;
        public string Flower;
        public string class_flower;
        public int Number_of_Tree;
        public string Height_of_tree;
        public string Circumference_of_Tree;
    }
    class SunFlower
    {
        public int User;
        public string Flower;
        public string class_flower;
        public int Number_of_Tree;
        public string Height_of_tree;
        public string Circumference_of_Tree;
    }
    class Information
    {
        public float[] FlowerInformation = new float[2];
        public Information(Rose_name_white,Rose_name_Red,Sun_flower_name_small, Sun_flower_name_big)
        {
            FlowerInformation[0] = Rose;
            FlowerInformation[1] = Flower;
            Console.WriteLine("Rose Information" + FlowerInformation[0]);
            Console.WriteLine("Flower Information" + FlowerInformation[1]);

            RoseFLower_name = new User();
            Plant_name1 = "\n";
            Console.WriteLine(Roseflower);
            SunFlower_name = new User();
            Plant_name2 = "\n";
            Console.WriteLine(SunFlower);
        }
    }
}
