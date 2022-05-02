﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt_Library.EntityFrameworkCode
{
    internal class EntityframeworkCategories
    {
        public static List<Models.Category> ShowAllCategories()
        {
            var categories = new List<Models.Category>();

            using (var db = new Models.Decrypt_LibraryContext())
            {
                categories = db.Categories.ToList();
                return categories;
            }
        }

        public static List<Models.Category> ShowAllProdutsInCateogry()
        {
            return null;
        }
    }
}