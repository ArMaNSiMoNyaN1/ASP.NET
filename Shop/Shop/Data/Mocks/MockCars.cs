using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.mocks;

public class MockCars : IAllCars
{
    private readonly ICarsCategory carsCategory = new MockCategory();

    public IEnumerable<Car> Cars {
        get
        {
            return new List<Car>
            {
                new Car
                {
                    id = 1,
                    brand = "Porsche", model = "Taycan Turbo S", shortDesc = "Stylish,quiet & quality car",
                    price = 89000, isFavourite = true,
                    img = "/img/taycan.jpg",
                    configurator = "https://configurator.porsche.com/en-WW/model/Y1AFM1?options=PA8.QL.QE1.VW6.4D5.GZ2.GT0.UD1.VC2.QK3.I89.1NK.A1.JH2.APT.KS1.QV3.7UG.2JB.9JA.6F0.QJ1.6FQ.FI6.9WU.7AK.4UF.1T3.9VJ.9AD.A8H.0TD.GV1.76C.5MH.7M8.8JU.2C7.QR9.6JD.4A4.VL2.3QT.6GA.4X3.E8A.8T6.QQ1.Q2J.KB3.K8S.6E1.4I0.3A1.6I3.NW0.0NB.2W9.1PE.6XV.VF0.7K3.9ZE.GM3.AI9.6K8.0N5.8VQ.2D0.UQ7.7HB.G1X.EM2.3FG.9M3.KA2.6NC.1X1.GH3.J9Q.MD3.5XC.3KH.5ZP.64X.1N3.J2B.AU1.IW3.1LQ.2FM.QW5.7X2.2V1.8LD.VR7&variants=APT_G1",
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 2,
                    brand = "BMW", model = "M5", shortDesc = "Beautiful, very fast, family sedan",
                    img = "/img/m5.jpg",
                    configurator = "https://www.bmw.am/en/all-models/m-series/m5-sedan/2021/bmw-5-series-sedan-m-automobiles-overview.html",
                    price = 100000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 3,
                    brand = "Maserati", model = "Ghilbi", shortDesc = "Very beautiful, fast, elegant sedan",
                    img = "/img/ghilbi.jpg", 
                    configurator = "https://www.maserati.com/fr/fr/shopping-tools/configurator?modelName=GH_MOQ4&modelYear=2024#/main/exteriors",
                    price = 75000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 4,
                    brand = "Bentley", model = "Continental GT", shortDesc = "Very beautiful, luxury, cabriolet",
                    img = "/img/continental.jpg",
                    configurator = "https://www.bentleymotors.com/en/misc/car-configurator.html/navigate/b7f491b0ace06bac3143fa3e9decc75f/configuration/continental_gt/continental-gt-speed/byPRsE168D91CQjEwQjEwQi1DMTc1MTc1LUM5MEE5MEEtQzkyNzkyNy1GMTQgNjU2MS1GNTYgICAgIDk5LUc4NUE4NUEtR0cwOUcwOS1HRzEwRzEwLUdHMzVHMzUtR0c1MUc1MS1HUEY4UEY4LUdQR0xQR0wtR1BJTFBJTC1HUExQUExQLUdSU0RSU0QtR1RTU1pXLUdXMjZXMjYtR1kxOFkxOC1HWTJXWTJXLUdZRERZREQtR1lYTVlYTS1HWkdCWkdCLUpDUkJZQS1KQ1JQU0gtSkVNQlNILUpNSERBWi1KUElQWlotSlNIRERSLUpTVENZQS1KU1RYWlgtTUdSVFZDMi1NTEVBTDBMLU1MUkEyUFAtTUxTRTlWSy1NT0JRRkwyLU1SQUExTlQtTVNMUjhRSy1NU1pVME5BLU1UWVoyWjQtTVZCSzFUMy1NV0FMOVRCLU1XU1M0R1ItTVpGTTBUQy1NWlVIOU0x",
                    price = 270000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 5,
                    brand = "McLaren", model = "750S", shortDesc = "Very fast supercar!",
                    img = "/img/mcalren.jpg",
                    configurator = "https://configurator.mclaren.com/mclaren-ui/?profile/750S-SPIDER",
                    price = 280000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 6,
                    brand = "Ferrari", model = "812 GTS", shortDesc = "Superfast!",
                    img = "/img/812.jpg",
                    configurator = "https://carconfigurator.ferrari.com/en_EN/ferrari_car_configurator/812gts/step/CLR?configuration=6c8434142022c16adfa5c3d82d3f4dcaee7783fe99bed80d85f06b7e70fc616d",
                    price = 320000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 7,
                    brand = "Lamborghini", model = "Urus S", shortDesc = "Beautiful, fast, family crossover",
                    img = "/img/urus.jpg",
                    configurator = "https://configurator.lamborghini.com/configurator/configuration/ePl9IIpV1dNdboMwDADgq_QCaKWF0T46CSG0BFACZMtddvfFNtkeNk3TXrYhK_pEfkRs8-HCVmzFqWrOVS7t-_Wxp8oiDueygYdznv8kI3IarSmkm9OohcRR8rh6U1ijRii8UUoUwUM6QpfVoeHC6PrxgM8Vq9HNpk9B8i4FKpSXQD3apc28vwtbmYJVp0A9S5-C5I8pULFfUiTdIEKMDJXRZhhrGPcMyxARGBLGHVOGE7ydro1QsO6YHINyQZBvSBkhLPvJOvR8jo4wAkNkGJ7qzL7YqIExiLBDjryGsoxw0vOU05qnvFiUILQ9T1ExCIPe30zrvniRGU_8qUHydSy0rqSsW1jVNcwoaeBksHZWtfduwQaxre1Hh3-b1e6ub1hma1pfswYHp3kj-fbiNMqBqhp65_18rIG0TRpqUlyPc__Fb_fTfvpDXfSt5vmVVvlPHfLyCnD6NaM/exterior?lang=ita&country=it",
                    price = 200000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 8,
                    brand = "Rolls Royse", model = "Cullinan", shortDesc = "Luxury  and quanlity",
                    img = "/img/RR.jpg",
                    configurator = "https://configure.rolls-roycemotorcars.com/en_LU/configure/RR31BB/TV61/1DF,2VB,319,322,420,453,454,460,477,4HC,4NM,4T6,4T7,508,548,5AC,5AS,5DF,5DL,5DP,5GB,601,609,610,654,6AC,6AE,6AK,6AM,6CP,6FR,6NW,6UK,6WD,853,880,8KL,8R9,8S3,L0E_ZH,L1T,L1Z,L2Q,L4A,L5A,LA0,LA2,LAF,LAN_ZH,LAP_ZH,LAS_ZH,LAV,LCP,LE1_KAV,LE5,LEC,LL1_R1,LL2_ZH,LL3_X1_LXMR,LLE,LM0_R1,LM1_R1,LM2_R1,LM3_R1,LM8_TU,LM9_R1,LMA_R1,LMB_R1,LMC_R1,LMD_R1,LMF_R1,LMK_R1,LML_ZH,LMP_R1,LMS_R1,LMT_R1,LMU_ZH,LMW_R1,LMX_R1,LMY_R1,R9K,RA1,RA5,RAE,RBY,RC5,RE6,RFR,RRS,RSF,RUE,WKAV,Z02,Z0G,Z1XX,Z2Q,Z9G,Z9K,Z9L,ZDP",
                    price = 400000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 9,
                    brand = "Maserati", model = "Levante", shortDesc = "Beautiful, fast, comfortable crossover",
                    img = "/img/maserati.jpg",
                    configurator = "https://www.maserati.com/fr/fr/shopping-tools/configurator?modelName=LV_MOQ4&modelYear=2024#/main/exteriors",
                    price = 130000, isFavourite = true,
                    available = true, Category = carsCategory.AllCategories.First()
                },
                new Car
                {
                    id = 10,
                    brand = "Tesla", model = "Model S", shortDesc ="Very fast, car with autopilot",
                    img = "/img/tesla.jpg",
                    configurator = "https://www.tesla.com/en_ae/models/design#overview",
                    price = 170000, isFavourite = true,
                    available = true, 
                    Category = carsCategory.AllCategories.First()
                },
            };

        }
    }

    public IEnumerable<Car> getFavCars { get; set; }

    public Car getObjectCar(int carId)
    {
        throw new NotImplementedException();
    }
}