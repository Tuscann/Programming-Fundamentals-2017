using System;

    class P03_RestaurantDiscount
    {
        static void Main() // 100/100
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePckage = Console.ReadLine();

            int servicePrice = 0;
            switch (servicePckage)
            {
                case "Normal":
                    servicePrice = 500;
                    break;
                case "Gold":
                    servicePrice = 750;
                    break;
                case "Platinum":
                    servicePrice = 1000;
                    break;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (groupSize <= 50)
            {
                string hallName = "Small Hall";
                int hallPrice = 2500;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
                return;
            }

            if (groupSize <= 100)
            {
                string hallName = "Terrace";
                int hallPrice = 5000;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
            }
            else // groupSize <= 120
            {
                string hallName = "Great Hall";
                int hallPrice = 7500;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
            }
        }

        static int ServicePckageDiscount(string servicePckage)
        {
            int discount = 0;
            switch (servicePckage)
            {
                case "Normal":
                    discount = 5;
                    break;
                case "Gold":
                    discount = 10;
                    break;
                case "Platinum":
                    discount = 15;
                    break;
            }

            return discount;
        }

        static void OutputPriceOffer(int groupSize, string servicePckage, int servicePrice, string hallName, int hallPrice)
        {
            int price = hallPrice + servicePrice;
            double discount = price * ServicePckageDiscount(servicePckage) / 100.0;
            double totalPrice = price - discount;
            double pricePerPerson = totalPrice / groupSize;
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
