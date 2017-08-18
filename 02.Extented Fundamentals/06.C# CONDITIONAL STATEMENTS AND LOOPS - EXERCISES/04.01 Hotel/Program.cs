using System;
using System.Collections.Generic;

class P04_Hotel
{
    static void Main() //100/100
    {
        string month = Console.ReadLine();
        int nightsInTheHotel = int.Parse(Console.ReadLine());

        Console.WriteLine($"Studio: {GetTotalPrice(month, nightsInTheHotel, "Studio"):F2} lv.");
        Console.WriteLine($"Double: {GetTotalPrice(month, nightsInTheHotel, "Double"):F2} lv.");
        Console.WriteLine($"Suite: {GetTotalPrice(month, nightsInTheHotel, "Suite"):F2} lv.");
    }

    static double GetTotalPrice(string month, int nightsInTheHotel, string roomType)
    {
        double totalPrice = GetPricePerNight(roomType, month) * nightsInTheHotel;
        double discount = 0.0;

        if (nightsInTheHotel > 14 && (roomType == "Double" || roomType == "Suite"))
        {
            if (roomType == "Double" && (month == "June" || month == "September"))
            {
                discount = totalPrice * GetDiscountPercent(month) / 100.0;
            }
            if (roomType == "Suite" && (month == "July" || month == "August" || month == "December"))
            {
                discount = totalPrice * GetDiscountPercent(month) / 100.0;
            }
        }
        else if (nightsInTheHotel > 7 && roomType == "Studio")
        {
            if (month == "September" || month == "October")
            {
                totalPrice -= GetPricePerNight(roomType, month);
            }

            if (month == "May" || month == "October")
            {
                discount = totalPrice * GetDiscountPercent(month) / 100.0;
            }
        }

        totalPrice -= discount;

        return totalPrice;
    }

    static int GetPricePerNight(string roomType, string month)
    {
        Dictionary<string, Dictionary<string, int>> priceTable = new Dictionary<string, Dictionary<string, int>>();
        priceTable.Add("Studio", new Dictionary<string, int>()
                {
                    {"May", 50},{"October", 50},
                    {"June", 60},{"September", 60},
                    {"July", 68},{"August", 68},{"December", 68}
                }
        );

        priceTable.Add("Double", new Dictionary<string, int>()
                {
                    {"May", 65}, {"October", 65},
                    {"June", 72}, {"September", 72},
                    {"July", 77}, {"August", 77}, {"December", 77}
                }
        );

        priceTable.Add("Suite", new Dictionary<string, int>()
                {
                    {"May", 75}, {"October", 75},
                    {"June", 82}, {"September", 82},
                    {"July", 89}, {"August", 89 }, {"December", 89}
                }
        );

        return priceTable[roomType][month];
    }

    static int GetDiscountPercent(string month)
    {
        Dictionary<string, int> discount = new Dictionary<string, int>();
        discount.Add("May", 5);
        discount.Add("October", 5);
        discount.Add("June", 10);
        discount.Add("September", 10);
        discount.Add("July", 15);
        discount.Add("August", 15);
        discount.Add("December", 15);

        return discount[month];
    }
}
