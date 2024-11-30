using PhoneBookCrud.Models;

namespace PhoneBookCrud.Sevices
{
   internal class PhoneBookService
   {
        public PhoneBookModel[] phoneBookModels { get; set; } = new PhoneBookModel[10];
        public PhoneBookService() 
        {
            phoneBookModels[0] = new PhoneBookModel()
            {
                Id = 1, Name = "My Phone",Phone = "998948997883"
            };  

        }
   }
}
