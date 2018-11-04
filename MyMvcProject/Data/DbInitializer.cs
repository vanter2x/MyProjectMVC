using Microsoft.EntityFrameworkCore.Internal;
using MyMvcProject.Models;
using System;

namespace MyMvcProject.Data
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Posts.Any())
            {
                context.AddRange(
                    new PostDTO("Tytul1", "sadsadasd asd safd asd asd a dasd asd d asd asd asd assf ag ", new DateTime(2018, 8, 8, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Dwa", "hgjgfhd a dasd asd d asd asd asd assf ag ", new DateTime(2018, 8, 12, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Trzy", "sfgvnbvbnvbnvbn asd asd a dasd asd d asd asd asd assf ag ", new DateTime(2018, 8, 14, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Cztery", "ppopiuuyiyuoyuoyuioiuasd asd d asd asd asd assf ag ", new DateTime(2018, 8, 22, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Pięć", "6556jhggd asd a dasd asd d asd asd asd assf ag ", new DateTime(2018, 8, 28, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Sześć", "097678ghnn6n65d asd asd assf ag ", new DateTime(2018, 9, 8, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2)),
                    new PostDTO("Siedem", "qweqweqeqweqewd a dasd asd d asd asd asd assf ag ", new DateTime(2018, 9, 9, 12, 22, 2), new DateTime(2018, 8, 8, 12, 22, 2))
                    );
            }

            context.SaveChanges();
        }
    }
}