using System;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace novelka
{
    class Programm
    {
        static void Main()
        {
            System.Console.WriteLine("Привет никита, надеюсь ты прочитал описание novelka.cs.Я обязуюсь, такого больше не будет(мэйби).(рекомендую не играть пока не прочитаешь)\nПриветствую в новелке, она про поездеку в голубы.\nВ данный момент вы на Мостовском Автовокзале.Вы зашли в автобус, выберите с кем сесть\n1.Бабушка\n2.Дедушка\n3.Женщина с грудным ребенком\n4.Красивая альтушка\n5.Женщина с псом");
            string UserChoice = Console.ReadLine();
            if (1 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы подсели к бабушке.Она начала разговор\nМилок, ты до куда\nДо голубов\nА ты чей? Что ответите\n1.Назвать фамилию\n2.Соврать.");
                string FirstUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(FirstUserChoice))
                {
                    System.Console.WriteLine("О так она моя подружка.Всю поездку вы слушали рассказы из детства связаные с вашей бабушкой.Вам было интересно.Хорошая концовка.");
                }
                if (2 == Convert.ToInt32(FirstUserChoice))
                {
                    System.Console.WriteLine("Понятно\nВсю дальнейшую дорогу вы проехали в тишине.Нормальная концовка");
                }
            }
            if (2 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы сели к дедушке\nТы куда едешь? Что ответие\n1.Сделать вид что не слышите\n2.Ответить");
                string SecondUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(SecondUserChoice))
                {
                    System.Console.WriteLine("Ну ладно\nДальнейшую дорогу вы проехали спокойно.Нормальная концовка");
                }
                if (2 == Convert.ToInt32(SecondUserChoice))
                {
                    System.Console.WriteLine("Вы ответили,и немного поговорили с этим дедом.Когда вы уже собирались выходит он вас окликнул и дал сало.Хорошая концовка");
                }
            }
            if (3 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы уселись около женщины, сначала все было хорошо, но потом ее чертовое чадо начало ныть.Что ответите\n1.Скажете чтоб она закрыла ему рот\n2.Промолчите");
                string ThirdUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(ThirdUserChoice))
                {
                    System.Console.WriteLine("Что?! Да как ты смеешь?!.Весь автобус ополчился против вас.Вас задавили морально.Плохая концовка");
                }
                if (2 == Convert.ToInt32(ThirdUserChoice))
                {
                    System.Console.WriteLine("Вы ничего не сказали,также вам очень разболелась голова.После выхода из автобуса вы упали в обморок.Ужасная концовка");
                }
            }
            if (4 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Она была прекрасна, как афродита, как из того самого сна.Что сделаете?\n1.Заговорите с ней\n2.Промолчите");
                string FourthUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(FourthUserChoice))
                {
                    System.Console.WriteLine("Я не знакомлюсь\nЭти слова как пуля которая прошла ваше сердце,вам было очень плохо.Самая худшая концовка");
                }
                if (2 == Convert.ToInt32(FourthUserChoice))
                {
                    System.Console.WriteLine("Вы долго винили себя в том что не познакомились,хотя,может это было к лучшему.Плохая концовка");
                }
            }
            if (5 == Convert.ToInt32(UserChoice))
            {
                System.Console.WriteLine("Вы сели, пес был около ваших ног.Что сделаете\n1.Погладите\n2.Ничего не сделаете");
                string FifthUserChoice = Console.ReadLine();
                if (1 == Convert.ToInt32(FifthUserChoice))
                {
                    System.Console.WriteLine("Вы погладили песика, он был счаслив.Но придя домой вы обнаружили на себе не лицеприятных паразитов.Плохая концовка");
                }
                if (2 == Convert.ToInt32(FifthUserChoice))
                {
                    System.Console.WriteLine("Вы просто доехали.Хорошая концовка");
                }
            }
            System.Console.WriteLine("Creator is nkplg PPT");
        }
    }
}