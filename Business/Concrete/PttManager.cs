using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager: ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            // new şeklinde başka sınıf kullanmak sınıfları birbire bağımlı hale getirir ve sorun çıkarabilir.
            // PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
