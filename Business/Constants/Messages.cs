﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car is Added";
        public static string CarNameInvalid = "Car's name is invalid";
        public static string MaintenanceTime = "Sistem at maintenance";
        public static string CarsListed = "Cars had listed";
        public static string RentalsListed="Rentals had listed";

        public static string RentalAdded = "Rental added";
        public static string RentalNotAdded = "Rental Not added, there is a car who has same car id";
        public static string ImageAdded="İmage added";
        public static string ImagesListed="image listed";
        public static string AuthorizationDenied = "Authorization denied";
        internal static string CarHasFiveImages="Car already has 5 images you cant added more";
    }
}
