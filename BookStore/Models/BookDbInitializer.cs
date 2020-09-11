using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookDbInitializer: DropCreateDatabaseAlways<BookContext> 
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { BookName = "Война и мир", BookAuthor = "Л. Толстой", BookPrice = 500 });
            db.Books.Add(new Book { BookName = "Отцы и дети", BookAuthor = "И. Тургенев", BookPrice = 350 });
            db.Books.Add(new Book { BookName = "Чайка", BookAuthor = "А. Чехов", BookPrice = 350 });

            base.Seed(db);
        }
    }
        
    
}