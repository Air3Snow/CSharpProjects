using System;

namespace TestReflect
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player_1 = new Player("玩家1");
           //Player player_2 = new Player("玩家2");
            Console.WriteLine("player_1.Life:" + player_1.Life);

            String drugsName = "TestReflect.JinDrugs";
            
            Type drug = Type.GetType(drugsName);

            //drug.GetMethod("AddLife").Invoke(drug, new Object[] { player_1 });
            try
            {
                Drugs drugObj = (Drugs)System.Activator.CreateInstance(drug);
                drugObj.GetType().GetMethod("AddLife").Invoke(drugObj, new Object[] { player_1 });
            }
            catch (Exception)
            {

                throw;
            }



            Console.WriteLine("player_1.Life:" + player_1.Life);
            Console.ReadLine();
        }
    }
}
