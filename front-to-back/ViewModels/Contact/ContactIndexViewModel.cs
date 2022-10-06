using front_to_back.Models;

namespace front_to_back.ViewModels.Contact
{
    public class ContactIndexViewModel
    {
        public ContractIntroComponent ContractIntroComponent { get; set; }
        public ContactSuccessComponent ContactSuccessComponent { get; set; } 

        public List<ContactContentComponent> ContactContentComponents { get; set; }  
    }
}
