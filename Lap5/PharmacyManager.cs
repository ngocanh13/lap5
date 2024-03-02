using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap.Lap5
{
    internal class PharmacyManager
    {
        public List<Category> Categories { get; set; }

        public PharmacyManager()
        {
            Categories = new List<Category>();
        }

        public void AddMedicine(string categoryName, Medicine medicine)
        {
            Category category = Categories.Find(c => c.Name == categoryName);
            if (category != null)
            {
                category.Medicines.Add(medicine);
                Console.WriteLine($"Added {medicine.Name} to {categoryName} category.");
            }
            else
            {
                Console.WriteLine($"Category {categoryName} not found.");
            }
        }

        public void DisplayMedicinesByCategory(string categoryName)
        {
            Category category = Categories.Find(c => c.Name == categoryName);
            if (category != null)
            {
                Console.WriteLine($"Medicines in {categoryName} category:");
                foreach (Medicine medicine in category.Medicines)
                {
                    Console.WriteLine($"Name: {medicine.Name}, Quantity: {medicine.Quantity}, Price: {medicine.Price}");
                }
            }
            else
            {
                Console.WriteLine($"Category {categoryName} not found.");
            }
        }

        public void DisplayMedicineDetails(string medicineName)
        {
            foreach (Category category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    Console.WriteLine($"Medicine Details - Name: {medicine.Name}, Quantity: {medicine.Quantity}, Price: {medicine.Price}");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }

        public void SearchMedicine(string medicineName)
        {
            foreach (Category category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    Console.WriteLine($"Medicine Found - Name: {medicine.Name}, Quantity: {medicine.Quantity}, Price: {medicine.Price}");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }

        public void UpdateMedicine(string medicineName, int quantity, decimal price)
        {
            foreach (Category category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    medicine.Quantity = quantity;
                    medicine.Price = price;
                    Console.WriteLine($"Updated information for medicine {medicineName}.");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }

        public void DeleteMedicine(string medicineName)
        {
            foreach (Category category in Categories)
            {
                Medicine medicine = category.Medicines.Find(m => m.Name == medicineName);
                if (medicine != null)
                {
                    category.Medicines.Remove(medicine);
                    Console.WriteLine($"Deleted medicine {medicineName}.");
                    return;
                }
            }
            Console.WriteLine($"Medicine {medicineName} not found.");
        }
    }
}
