using System;
using System.Collections.Generic;
using System.Linq;
using CarMarketWithLogin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CarMarketWithLogin.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationDbContext content)
        {
            
            // content.Database.EnsureDeleted();
            // content.Database.EnsureCreated();
           
            if (!content.Transmissions.Any() && !content.Cars.Any())
            {
                Capacity capacity1_0 = new Capacity {Name = 1.0};
                Capacity capacity1_1 = new Capacity {Name = 1.1};
                Capacity capacity1_2= new Capacity {Name = 1.2};
                Capacity capacity1_3= new Capacity {Name = 1.3};
                Capacity capacity1_4= new Capacity {Name = 1.4};
                Capacity capacity1_5= new Capacity {Name = 1.5};
                Capacity capacity1_6= new Capacity {Name = 1.6};
                Capacity capacity1_7= new Capacity {Name = 1.7};
                Capacity capacity1_8= new Capacity {Name = 1.8};
                Capacity capacity1_9= new Capacity {Name = 1.9};
                Capacity capacity2_0= new Capacity {Name = 2.0};
                Capacity capacity2_1= new Capacity {Name = 2.1};
                Capacity capacity2_2= new Capacity {Name = 2.2};
                Capacity capacity2_3= new Capacity {Name = 2.3};
                Capacity capacity2_4= new Capacity {Name = 2.4};
                Capacity capacity2_5= new Capacity {Name = 2.5};
                Capacity capacity2_6= new Capacity {Name = 2.6};
                Capacity capacity2_7= new Capacity {Name = 2.7};
                Capacity capacity2_8= new Capacity {Name = 2.8};
                Capacity capacity2_9= new Capacity {Name = 2.9};
                Capacity capacity3_0= new Capacity {Name = 3.0};
                Capacity capacity3_1= new Capacity {Name = 3.1};
                Capacity capacity3_2= new Capacity {Name = 3.2};
                Capacity capacity3_3= new Capacity {Name = 3.3};
                Capacity capacity3_4= new Capacity {Name = 3.4};
                Capacity capacity3_5= new Capacity {Name = 3.5};
                Capacity capacity3_6= new Capacity {Name = 3.6};
                Capacity capacity3_7= new Capacity {Name = 3.7};
                Capacity capacity3_8= new Capacity {Name = 3.8};
                Capacity capacity3_9= new Capacity {Name = 3.9};
                Capacity capacity4_0= new Capacity {Name = 4.0};
                Capacity capacity4_1= new Capacity {Name = 4.1};
                Capacity capacity4_2= new Capacity {Name = 4.2};
                Capacity capacity4_3= new Capacity {Name = 4.3};
                Capacity capacity4_4= new Capacity {Name = 4.4};
                Capacity capacity4_5= new Capacity {Name = 4.5};
                Capacity capacity4_6= new Capacity {Name = 4.6};
                Capacity capacity4_7= new Capacity {Name = 4.7};
                Capacity capacity4_8= new Capacity {Name = 4.8};
                Capacity capacity4_9= new Capacity {Name = 4.9}; 
                Capacity capacity5_0= new Capacity {Name = 5.0};

                Transmission automaticTransmission = new Transmission {Name = "Auto"};
                Transmission manualTransmission = new Transmission {Name = "Manual"};

                BodyType sedanBodyType = new BodyType {Name = "Sedan",};
                BodyType hatchbackBodyType = new BodyType {Name = "Hatchback"};
                BodyType stationWagonBodyType = new BodyType {Name = "Station wagon"};
                BodyType cabrioletBodyType = new BodyType {Name = "Cabriolet"};
                BodyType minivanBodyType = new BodyType {Name = "Minivan"};
                BodyType limousineBodyType = new BodyType {Name = "Limousine"};
                BodyType coupeBodyType = new BodyType {Name = "Coupe"};
                BodyType pickupBodyType = new BodyType {Name = "Pickup"};
                BodyType crossoverBodyType = new BodyType {Name = "Crossover"};
                BodyType liftbackBodyType = new BodyType {Name = "liftback"};

                DriveUnit AWD = new DriveUnit {Name = "AWD"};
                DriveUnit RWD = new DriveUnit {Name = "RWD"};
                DriveUnit FWD = new DriveUnit {Name = "FWD"};

                EngineType diesel = new EngineType {Name = "Diesel", GroupName = "ICE"};
                EngineType petrol = new EngineType {Name = "Petrol", GroupName = "ICE"};
                EngineType hybrid = new EngineType {Name = "Hybrid", GroupName = "Hybrid"};
                EngineType electro = new EngineType {Name = "Electric", GroupName = "Electric"};

                Img pegeotImg1 = new Img {Url = "/img/Pegeot 605/1.jpg"};
                Img pegeotImg2 = new Img {Url = "/img/Pegeot 605/2.jpg"};
                Img pegeotImg3 = new Img { Url = "/img/Pegeot 605/3.jpeg"};
                Img pegeotImg4 = new Img { Url = "/img/Pegeot 605/4.jpg"};

                Img renaultImg1 = new Img {Url = "/img/Renault 19/1.jpg"};
                Img renaultImg2 = new Img {Url = "/img/Renault 19/2.jpg"};
                Img renaultImg3 = new Img { Url = "/img/Renault 19/3.jpg"};
                Img renaultImg4 = new Img { Url = "/img/Renault 19/4.jpeg"};

                Img bmwImg1 = new Img {Url = "/img/BMW X5/1.jpg"};
                Img bmwImg2 = new Img { Url = "/img/BMW X5/2.jpg"};
                Img bmwImg3 = new Img { Url = "/img/BMW X5/3.jpg"};
                Img bmwImg4 = new Img { Url = "/img/BMW X5/4.jpg"};

                Img mazdaImg1 = new Img {Url = "/img/Mazda6/1.jpg"};
                Img mazdaImg2 = new Img { Url = "/img/Mazda6/2.jpg"};
                Img mazdaImg3 = new Img { Url = "/img/Mazda6/3.jpg"};
                Img mazdaImg4 = new Img { Url = "/img/Mazda6/4.jpg"};

                Img audiImg1 = new Img { Url = "/img/Audi A5/1.jpg"};
                Img audiImg2 = new Img { Url = "/img/Audi A5/2.jpg"};
                Img audiImg3 = new Img { Url = "/img/Audi A5/3.jpg"};
                Img audiImg4 = new Img { Url = "/img/Audi A5/4.jpg"};

                Img nissanImg1 = new Img {Url = "/img/Nissan Leaf/1.jpg"};
                Img nissanImg2 = new Img { Url = "/img/Nissan Leaf/2.jpg"};
                Img nissanImg3 = new Img { Url = "/img/Nissan Leaf/3.jpg"};
                Img nissanImg4 = new Img { Url = "/img/Nissan Leaf/4.jpg"};

                Img toyotaImg1 = new Img {Url = "/img/Toyota Prius/1.jpg"};
                Img toyotaImg2 = new Img {Url = "/img/Toyota Prius/2.jpg"};
                Img toyotaImg3 = new Img { Url = "/img/Toyota Prius/3.jpg"};
                Img toyotaImg4 = new Img { Url = "/img/Toyota Prius/4.jpg"};

                Img nissanXImg1 = new Img {Url = "/img/Nissan X-Trail/1.jpg"};
                Img nissanXImg2 = new Img {Url = "/img/Nissan X-Trail/2.jpg"};
                Img nissanXImg3 = new Img {Url = "/img/Nissan X-Trail/3.jpg"};
                Img nissanXImg4 = new Img {Url = "/img/Nissan X-Trail/4.jpg"};
                
                Car Pegeot = new Car()
                {
                    Brand = "Pegeot",
                    Model = "605",
                    Generation = 2,
                    TheHighestPrice = 5000,
                    TheLowestPrice = 550,
                    RecommendPrice = 2200,
                    StartYear = 1994,
                    EndYear = 1999,
                    Transmissions = new List<Transmission>{automaticTransmission, manualTransmission},
                    BodyType = new List<BodyType>{sedanBodyType},
                    DriveUnit = new List<DriveUnit>{FWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity2_0, capacity2_1, capacity2_5, capacity3_0},
                    Imgs = new List<Img>{pegeotImg1,pegeotImg2,pegeotImg3,pegeotImg4 }
                };

                Car BMW = new Car()
                {
                    Brand = "BMW", 
                    Model = "X5",
                    Generation = 1,
                    TheHighestPrice = 16000,
                    TheLowestPrice = 5000,
                    RecommendPrice = 9000,
                    StartYear = 1999,
                    EndYear = 2006,
                    Transmissions = new List<Transmission>{automaticTransmission,manualTransmission},
                    BodyType = new List<BodyType>{crossoverBodyType},
                    DriveUnit = new List<DriveUnit>{AWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity3_0, capacity3_5, capacity4_4},
                    Imgs = new List<Img>{bmwImg1,bmwImg2,bmwImg3,bmwImg4 }
                };

                Car Renault = new Car()
                {
                    Brand = "Renault", 
                    Model = "19",
                    Generation = 1,
                    TheHighestPrice = 900,
                    TheLowestPrice = 190,
                    RecommendPrice = 650,
                    StartYear = 1988,
                    EndYear = 1992,
                    Transmissions = new List<Transmission>{manualTransmission},
                    BodyType = new List<BodyType>{hatchbackBodyType, sedanBodyType, coupeBodyType},
                    DriveUnit = new List<DriveUnit>{FWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity1_4, capacity1_7, capacity1_8},
                    Imgs = new List<Img>{renaultImg1,renaultImg2,renaultImg3,renaultImg4}
                };

                Car Mazda = new Car()
                {
                    Brand = "Mazda",
                    Model = "6",
                    Generation = 1,
                    TheHighestPrice = 8000,
                    TheLowestPrice = 1700,
                    RecommendPrice = 4500,
                    StartYear = 2002,
                    EndYear = 2008,
                    Transmissions = new List<Transmission>{automaticTransmission,manualTransmission},
                    BodyType = new List<BodyType>{sedanBodyType, stationWagonBodyType, liftbackBodyType},
                    DriveUnit = new List<DriveUnit>{FWD, AWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity1_8, capacity2_0, capacity2_3, capacity3_0},
                    Imgs = new List<Img>{mazdaImg1,mazdaImg2,mazdaImg3,mazdaImg4}
                };

                Car Audi = new Car()
                {
                    Brand = "Audi",
                    Model = "A5",
                    Generation = 1,
                    TheHighestPrice = 17400,
                    TheLowestPrice = 8000,
                    RecommendPrice = 13000,
                    StartYear = 2007,
                    EndYear = 2011,
                    Transmissions = new List<Transmission>{automaticTransmission,manualTransmission},
                    BodyType = new List<BodyType>{coupeBodyType, sedanBodyType},
                    DriveUnit = new List<DriveUnit>{FWD, AWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity1_8, capacity2_0, capacity3_2},
                    Imgs = new List<Img>{audiImg1,audiImg2,audiImg3,audiImg4}
                };

                Car Nissan = new Car()
                {
                    Brand = "Nissan", 
                    Model = "Leaf",
                    Generation = 1,
                    TheHighestPrice = 12500,
                    TheLowestPrice = 8000,
                    RecommendPrice = 15300,
                    StartYear = 2009,
                    EndYear = 2017,
                    Transmissions = new List<Transmission>{automaticTransmission},
                    BodyType = new List<BodyType>{hatchbackBodyType},
                    DriveUnit = new List<DriveUnit>{FWD},
                    EngineType = new List<EngineType>{electro},
                    Capacities = null,
                    Imgs = new List<Img>{nissanImg1,nissanImg2,nissanImg3,nissanImg4}
                };

                Car Toyota = new Car()
                {
                    Brand = "Toyota",
                    Model = "Prius",
                    Generation = 1,
                    TheHighestPrice = 4700,
                    TheLowestPrice = 4200,
                    RecommendPrice = 4450,
                    StartYear = 1997,
                    EndYear = 2003,
                    Transmissions = new List<Transmission>{automaticTransmission},
                    BodyType = new List<BodyType>{sedanBodyType},
                    DriveUnit = new List<DriveUnit>{FWD},
                    EngineType = new List<EngineType>{hybrid},
                    Capacities = new List<Capacity>{capacity1_5},
                    Imgs = new List<Img>{toyotaImg1,toyotaImg2,toyotaImg3,toyotaImg4}
                };
                
                Car NissanX = new Car()
                {
                    Brand = "Nissan",
                    Model = "X-Trail",
                    Generation = 1,
                    TheHighestPrice = 11000,
                    TheLowestPrice = 2950,
                    RecommendPrice = 8000,
                    StartYear = 2001,
                    EndYear = 2007,
                    Transmissions = new List<Transmission>{automaticTransmission, manualTransmission},
                    BodyType = new List<BodyType>{crossoverBodyType},
                    DriveUnit = new List<DriveUnit>{FWD, AWD},
                    EngineType = new List<EngineType>{diesel, petrol},
                    Capacities = new List<Capacity>{capacity2_0, capacity2_2, capacity2_5},
                    Imgs = new List<Img>{nissanXImg1,nissanXImg2,nissanXImg3,nissanXImg4}
                };
                
                automaticTransmission.Cars = new List<Car>{Pegeot,Audi,BMW,Nissan,Toyota,Mazda, NissanX};
                manualTransmission.Cars = new List<Car>{Pegeot, BMW, Audi, Renault, NissanX};
                
                sedanBodyType.Cars = new List<Car>{Pegeot, Audi, Renault, Mazda};
                hatchbackBodyType.Cars = new List<Car>{Nissan, Renault};
                stationWagonBodyType.Cars = new List<Car>{Mazda};
                coupeBodyType.Cars = new List<Car>{Renault, Audi};
                crossoverBodyType.Cars = new List<Car> {BMW, NissanX};
                liftbackBodyType.Cars = new List<Car>{Mazda};

                AWD.Cars = new List<Car> {Audi, Mazda, BMW, NissanX};
                FWD.Cars = new List<Car> {Pegeot, Renault, Nissan, Audi, Mazda, Toyota, NissanX};
                RWD.Cars = new List<Car>();

                petrol.Cars = new List<Car> {Pegeot, Audi, Mazda, Renault, BMW, NissanX};
                diesel.Cars = new List<Car> {Pegeot, Audi, Mazda, Renault, BMW, NissanX};
                hybrid.Cars = new List<Car> {Toyota};
                electro.Cars = new List<Car> {Nissan};

                capacity1_5.Cars = new List<Car> {Toyota};
                capacity1_4.Cars = new List<Car> {Renault};
                capacity1_7.Cars = new List<Car> {Renault};
                capacity1_8.Cars = new List<Car> {Renault, Mazda, Audi};
                capacity2_0.Cars = new List<Car> {Pegeot, Mazda, Audi, NissanX};
                capacity2_1.Cars = new List<Car> {Pegeot};
                capacity2_2.Cars = new List<Car> {NissanX};
                capacity2_5.Cars = new List<Car> {Pegeot, NissanX};
                capacity2_3.Cars = new List<Car> {Mazda};
                capacity3_0.Cars = new List<Car> {Pegeot, BMW, Mazda};
                capacity3_2.Cars = new List<Car>{Audi};
                capacity3_5.Cars = new List<Car>{BMW};
                capacity4_4.Cars = new List<Car> {BMW};
                
                content.Imgs.AddRange(pegeotImg1,pegeotImg2,pegeotImg3,pegeotImg4, renaultImg1,renaultImg2,renaultImg3,renaultImg4, mazdaImg1,mazdaImg2,mazdaImg3,mazdaImg4, audiImg1,audiImg2,audiImg3,audiImg4, bmwImg1,bmwImg2,bmwImg3,bmwImg4, nissanImg1,nissanImg2,nissanImg3,nissanImg4, toyotaImg1,toyotaImg2,toyotaImg3,toyotaImg4,nissanXImg1,nissanXImg2,nissanXImg3,nissanXImg4);
                content.BodyTypes.AddRange(sedanBodyType, hatchbackBodyType, stationWagonBodyType, coupeBodyType, crossoverBodyType, liftbackBodyType);
                content.DriveUnits.AddRange(AWD,FWD,RWD);
                content.EngineTypes.AddRange(petrol, diesel, hybrid, electro);
                content.Capacities.AddRange(capacity1_5, capacity1_4, capacity1_7, capacity1_8, capacity2_0, capacity2_1, capacity2_2, capacity2_5, capacity2_3, capacity3_0, capacity3_2, capacity3_5, capacity4_4);
                content.Transmissions.AddRange(automaticTransmission, manualTransmission);
                content.Cars.AddRange(Pegeot, Audi, Mazda, Nissan, Renault, Toyota, BMW, NissanX);
                content.SaveChanges();

            }

            IdentityUser admin = new User
            {
                Id = 1.ToString(),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = null,
                NormalizedEmail = "admin",
                EmailConfirmed = true,
                PasswordHash = "admin",
                SecurityStamp = "admin",
                ConcurrencyStamp = null,
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = false,
                AccessFailedCount = 0,
            };

            // IdentityRole adminRole = new IdentityRole
            // {
            //     Name = "admin",
            //     NormalizedName = "admin",
            // };
            // IdentityRole commonRole = new IdentityRole
            // {
            //     Name = "common",
            //     NormalizedName = "common",
            // };
            
            

            content.SaveChanges();
        }
    }
}