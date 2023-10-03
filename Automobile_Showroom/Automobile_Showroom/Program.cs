using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Course
{
    internal class AutoMobileShowroomProject
    {

        class CarType
        {
            public int carPrice = 0;
            public string carName = "";
            public int CarTypes()
            {

                int error = 0;
                int ct = 0;

                Console.WriteLine(" ---------------Select Car Type-------------- ");
                do
                {
                    Console.WriteLine("\n1.Hatchback  2.Sedan  3.SUV  4.Luxury");
                    ct = Convert.ToInt32(Console.ReadLine());
                    if (ct >= 1 && ct <= 4)
                    {
                        error = 0;
                        return ct;

                    }
                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }
                } while (error != 0);
                return ct;

            }

            public int Hatchback()
            {
                int error = 0;
                int hb = 0;

                Console.WriteLine();
                Design.ModelName();
                do
                {
                    Console.WriteLine("1. BMW 640i   Price - 45,00,000 \n2. BMW 128ti  Price - 35,00,000");
                    Console.WriteLine("3. BMW M135i  Price - 40,00,000 \n4. BMW 116    Price - 32,00,000 \n5. Back");
                    hb = Convert.ToInt32(Console.ReadLine());
                    if (hb >= 1 && hb <= 5)
                    {
                        if (hb == 1)
                        {
                            carName = "BMW 640i";
                            carPrice = 4500000;
                            error = 0;
                        }
                        else if (hb == 2)
                        {
                            carName = "BMW 128ti";
                            carPrice = 3500000;
                            error = 0;
                        }
                        else if (hb == 3)
                        {
                            carName = "BMW M135i";
                            carPrice = 4000000;
                            error = 0;
                        }
                        else if (hb == 4)
                        {
                            carName = "BMW 116";
                            carPrice = 3200000;
                            error = 0;
                        }
                        return hb;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }

                } while (error != 0);
                return hb;
            }
            public int Sedan()
            {
                int error = 0;
                int sD = 0;
                Console.WriteLine();
                Design.ModelName();
                do
                {
                    Console.WriteLine("1. BMW M3  Price - 65,00,000 \n2. BMW M5  Price - 70,00,000 ");
                    Console.WriteLine("3. BMW M7  Price - 90,00,000 \n4. BMW M8  Price -  80,00,000 \n5. Back");
                    sD = Convert.ToInt32(Console.ReadLine());
                    if (sD >= 1 && sD <= 5)
                    {
                        if (sD == 1)
                        {
                            carName = "BMW M3";
                            carPrice = 6500000;
                            error = 0;
                        }
                        else if (sD == 2)
                        {
                            carName = "BMW M5";
                            carPrice = 7000000;
                            error = 0;
                        }
                        else if (sD == 3)
                        {
                            carName = "BMW M7";
                            carPrice = 9000000;
                            error = 0;
                        }
                        else if (sD == 4)
                        {
                            carName = "BMW M8";
                            carPrice = 8000000;
                            error = 0;
                        }
                        return sD;
                    }

                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }

                } while (error != 0);
                return sD;
            }
            public int SUV()
            {
                int error = 0;
                int sUV = 0;
                Console.WriteLine();
                Design.ModelName();
                do
                {
                    Console.WriteLine("1. BMW X1  Price - 55,00,000 \n2. BMW X5  Price - 80,00,000 ");
                    Console.WriteLine("3. BMW X7  Price - 90,00,000 \n4. BMW XM  Price - 95,00,000 Cr \n5. Back");
                    sUV = Convert.ToInt32(Console.ReadLine());
                    if (sUV >= 1 && sUV <= 5)
                    {
                        if (sUV == 1)
                        {
                            carName = "BMW X1";
                            carPrice = 5500000;
                            error = 0;
                        }
                        else if (sUV == 2)
                        {
                            carName = "BMW X5";
                            carPrice = 8000000;
                            error = 0;
                        }
                        else if (sUV == 3)
                        {
                            carName = "BMW X7";
                            carPrice = 9000000;
                            error = 0;
                        }
                        else if (sUV == 4)
                        {
                            carName = "BMW XM";
                            carPrice = 9500000;
                            error = 0;
                        }
                        error = 0;
                        return sUV;
                    }

                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }

                } while (error != 0);
                return sUV;
            }
            public int Luxury()
            {
                int error = 0;
                int lXR = 0;
                Console.WriteLine();
                Design.ModelName();
                do
                {
                    Console.WriteLine("1. BMW i8  Price - 99,00,000 Cr \n2. BMW Z8  Price - 60,00,000 ");
                    Console.WriteLine("3. BMW M4  Price - 75,00,000 \n4. BMW i4  Price - 80,00,000  \n5. Back");
                    lXR = Convert.ToInt32(Console.ReadLine());
                    if (lXR >= 1 && lXR <= 5)
                    {
                        if (lXR == 1)
                        {
                            carName = "BMW i8";
                            carPrice = 9900000;
                            error = 0;
                        }
                        else if (lXR == 2)
                        {
                            carName = "BMW Z8";
                            carPrice = 6000000;
                            error = 0;
                        }
                        else if (lXR == 3)
                        {
                            carName = "BMW M4";
                            carPrice = 7500000;
                            error = 0;
                        }
                        else if (lXR == 4)
                        {
                            carName = "BMW i4";
                            carPrice = 8000000;
                            error = 0;
                        }
                        error = 0;
                        return lXR;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }

                } while (error != 0);
                return lXR;
            }


        }
        class Accessories
        {
            public int colourPrice = 0;
            public String colourName = "";
            public int carCover = 0;
            public int seatCoverP = 0;
            public int floorMatsP = 0;
            public int Colour()
            {

                int clr = 0;
                int run = 0;

                Console.WriteLine();
                Console.WriteLine("---------------Select Car Colour---------------");
                do
                {

                    Console.WriteLine("1. White\n2. Red\n3. Blue \n4. Black \n5. Back");
                    clr = Convert.ToInt32(Console.ReadLine());

                    if (clr == 1)
                    {
                        colourName = "White";
                        colourPrice = 20000;
                        run = 0;
                    }
                    else if (clr == 2)
                    {
                        colourName = "Red";
                        colourPrice = 30000;
                        run = 0;
                    }
                    else if (clr == 3)
                    {
                        colourName = "Blue";
                        colourPrice = 40000;
                        run = 0;
                    }
                    else if (clr == 4)
                    {
                        colourName = "Black";
                        colourPrice = 50000;
                        run = 0;
                    }
                    else if (clr == 5)
                    {
                        run = 0;
                        return clr;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        run = 1;
                    }


                } while (run != 0);
                return clr;

            }

            public int CarCover()
            {
                int cover = 0;
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Car Cover\n1. Yes   2. No 3. Back");
                    cover = Convert.ToInt32(Console.ReadLine());
                    if (cover == 1)
                    {
                        carCover = 5000;
                        return carCover;
                    }
                    if (cover == 2)
                    {
                        return carCover;
                    }
                    else if (cover == 3)
                    {
                        return cover;
                    }
                    {
                        Design.ErrorMsg();
                        cover = 0;
                    }

                } while (cover == 0);
                return cover;

            }
            public int seatCover()
            {
                int cover = 0;
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Seat Cover\n1. Yes   2. No 3. Back");
                    cover = Convert.ToInt32(Console.ReadLine());
                    if (cover == 1)
                    {
                        seatCoverP = 5000;
                        return seatCoverP;
                    }
                    if (cover == 2)
                    {
                        return seatCoverP;
                    }
                    else if (cover == 3)
                    {
                        return cover;
                    }
                    {
                        Design.ErrorMsg();
                        cover = 0;
                    }

                } while (cover == 0);
                return cover;

            }
            public int floorMats()
            {
                int mats = 0;
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Floor Mats\n1. Yes   2. No 3. Back");
                    mats = Convert.ToInt32(Console.ReadLine());
                    if (mats == 1)
                    {
                        floorMatsP = 2000;
                        return floorMatsP;
                    }
                    if (mats == 2)
                    {
                        return floorMatsP;
                    }
                    else if (mats == 3)
                    {
                        return mats;
                    }
                    {
                        Design.ErrorMsg();
                        mats = 0;
                    }

                } while (mats == 0);
                return mats;

            }
        }

        class Design
        {
            public static void ShowroomName()
            {
                Console.WriteLine();
                Console.WriteLine("----------------||**********||----------------");
                Console.WriteLine("|                   B M W                    |");
                Console.WriteLine("----------------||**********||----------------");

            }
            public static void ModelName()
            {
                Console.WriteLine("---------------Select Car Model-------------- ");
            }
            public static void ErrorMsg()
            {
                Console.WriteLine();
                Console.WriteLine("\nPlease choose Correct Option..!!!");
            }

        }
        class Loan
        {

            public int rate = 0;
            public int year = 0;
            public void EMi()
            {
                int error = 0;
                do
                {

                    Console.WriteLine("Select Rate \n1. 5%   2. 10%   3. 15%");
                    int crate = Convert.ToInt32(Console.ReadLine());
                    if (crate == 1)
                    {
                        rate = 15;
                        error = 0;
                    }
                    else if (crate == 2)
                    {
                        rate = 10;
                        error = 0;
                    }
                    else if (crate == 3)
                    {
                        rate = 15;
                        error = 0;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }
                } while (error != 0);
                error = 0;
                do
                {

                    Console.WriteLine("Select Period \n1. 3 Years   2. 5 Years  3. 7 Years");
                    int period = Convert.ToInt32(Console.ReadLine());
                    if (period == 1)
                    {
                        year = 3;
                        error = 0;
                    }
                    else if (period == 2)
                    {
                        year = 5;
                        error = 0;
                    }
                    else if (period == 3)
                    {
                        year = 7;
                        error = 0;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        error = 1;
                    }
                } while (error != 0);

            }

        }

        class Customer
        {
            public static int id = 0;
            public string name = "";
            public string gmail = "";
            public string ph = "";
            public string carName = "";
            public int carPrice = 0;
            public string colourName = "";
            public int colourPrice = 0;
            public int coverPrice = 0;
            public int seatCoverP = 0;
            public int floorMatsP = 0;
            public int rateOfInterest = 0;
            public int emiPeriod = 0;
            public int totalAmount = 0;
            public int taxAmount = 0;
            public int downPay = 0;
            public int emi = 0;
            public string paidBy = "";
            public Customer()
            {
                Console.WriteLine();
                id++;
                Console.Write("Enter Name -> ");
                name = Console.ReadLine();
                Console.Write("Enter Phone No. -> ");
                ph = Console.ReadLine();
                Console.Write("Enter Gmail -> ");
                gmail = Console.ReadLine();

            }

            public void details()
            {
                Console.WriteLine();
                Console.WriteLine("---------------Car Invoice--------------");
                Console.WriteLine("Id = " + id);
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Phone N0. = " + ph);
                Console.WriteLine("Gmail ID = " + gmail);
                Console.WriteLine("Car Name = " + carName);
                Console.WriteLine("Car Price = " + carPrice);
                taxAmount = (int)(carPrice * 0.13);
                Console.WriteLine("Tax Price 13% os Car price = " + taxAmount);
                Console.WriteLine("Car colour = " + colourName);
                Console.WriteLine("Colour Price = " + colourPrice);
                Console.WriteLine("Car Cover Price = " + coverPrice);
                Console.WriteLine("Seat Cover Price = " + seatCoverP);
                Console.WriteLine("Floor Mats Price = " + floorMatsP);
                totalAmount = carPrice + colourPrice + coverPrice + seatCoverP + floorMatsP + taxAmount;
                Console.WriteLine();
                Console.WriteLine("---------------Total Amount---------------");
                Console.WriteLine("Amount to Paid = " + totalAmount);
                Console.WriteLine();
            }
            public void FinalDetails()
            {
                Console.WriteLine();
                Console.WriteLine("---------------Final Amount Invoice---------------");
                Console.WriteLine();
                Console.WriteLine("Id = " + id);
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Phone N0. = " + ph);
                Console.WriteLine("Gmail ID = " + gmail);
                Console.WriteLine("Car Name = " + carName);
                Console.WriteLine("Car Price = " + carPrice);
                Console.WriteLine("Tax Price 13% of Car Price = " + taxAmount);
                Console.WriteLine("Car colour = " + colourName);
                Console.WriteLine("Colour Price = " + colourPrice);
                Console.WriteLine("Car Cover Price = " + coverPrice);
                Console.WriteLine("Seat Cover Price = " + seatCoverP);
                Console.WriteLine("Floor Mats Price = " + floorMatsP);
                totalAmount = carPrice + colourPrice + coverPrice + seatCoverP + floorMatsP + taxAmount;
                Console.WriteLine("Amount to Paid = " + totalAmount);
                if (paidBy == "EMI")
                {
                    Console.WriteLine("Rate of Interest = " + rateOfInterest + "%");
                    Console.WriteLine("EMI Period = " + emiPeriod);
                    Console.WriteLine("Downpayment = " + downPay);
                    Console.WriteLine("EMI = " + emi);
                }
                Console.WriteLine();
                Console.WriteLine("---------------Thank You---------------");
            }



        }

        class Program
        {

            struct DailyCustomerInfo
            {
                public int id;
                public string name;
                public string gmail;
                public string ph;
                public string carName;
                public int carPrice;
                public int carTaxAmount;
                public string colourName;
                public int colourPrice;
                public int coverPrice;
                public int seatCoverP;
                public int floorMatsP;
                public int rateOfInterest;
                public int emiPeriod;
                public int totalAmount;
                public int downPay;
                public int emi;
                public string paidBy;

            }

            static void Main(String[] args)
            {
                int id = 0;
                int dciPosition = 0;
                DailyCustomerInfo[] dci = new DailyCustomerInfo[10];
                Design.ShowroomName();
                Console.WriteLine("\n--Welcome To the Most SPECTACULAR car shop--\n");

                int run = 0;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("--------Enter Customer Details-------- ");
                    Customer cts = new Customer();
                    int emi = 0;
                    int run1 = 0;
                    do
                    {

                        CarType ct = new CarType();
                    cartyPE:
                        int cartype = ct.CarTypes();
                        switch (cartype)
                        {
                            case 1:
                            carModel:
                                int ht = ct.Hatchback();
                                if (ht == 5)
                                {
                                    goto cartyPE;
                                }
                                cts.carPrice = ct.carPrice;
                                cts.carName = ct.carName;
                                Accessories ac = new Accessories();
                            carColor:
                                int cr = ac.Colour();
                                if (cr == 5)
                                {
                                    goto carModel;
                                }
                                cts.colourName = ac.colourName;
                                cts.colourPrice = ac.colourPrice;
                                Console.WriteLine("--------------Car Accessories--------------");
                            carCover:
                                int cover = ac.CarCover();
                                cts.coverPrice = cover;
                                if (cover == 3)
                                {
                                    goto carColor;
                                }
                            seatCover:
                                int seatCover = ac.seatCover();
                                cts.seatCoverP = seatCover;
                                if (seatCover == 3)
                                {
                                    goto carCover;
                                }
                                int floorMat = ac.floorMats();
                                cts.floorMatsP = floorMat;
                                if (floorMat == 3)
                                {
                                    goto seatCover;
                                }
                                Console.WriteLine();
                                run1 = 1;
                                break;

                            case 2:
                            carModel2:
                                int sedan = ct.Sedan();
                                if (sedan == 5)
                                {
                                    goto cartyPE;
                                }
                                cts.carPrice = ct.carPrice;
                                cts.carName = ct.carName;
                                Accessories ac2 = new Accessories();
                            carColor2:
                                int cr2 = ac2.Colour();
                                if (cr2 == 5)
                                {
                                    goto carModel2;
                                }
                                cts.colourName = ac2.colourName;
                                cts.colourPrice = ac2.colourPrice;
                                Console.WriteLine("--------------Car Accessories--------------");
                            carCover2:
                                int cover2 = ac2.CarCover();
                                cts.coverPrice = cover2;
                                if (cover2 == 3)
                                {
                                    goto carColor2;
                                }
                            seatCover2:
                                int seatCover2 = ac2.seatCover();
                                cts.seatCoverP = seatCover2;
                                if (seatCover2 == 3)
                                {
                                    goto carCover2;
                                }
                                int floorMat2 = ac2.floorMats();
                                cts.floorMatsP = floorMat2;
                                if (floorMat2 == 3)
                                {
                                    goto seatCover2;
                                }
                                Console.WriteLine();
                                run1 = 1;
                                break;

                            case 3:
                            carModel3:
                                int suv = ct.SUV();
                                if (suv == 5)
                                {
                                    goto cartyPE;
                                }
                                cts.carPrice = ct.carPrice;
                                cts.carName = ct.carName;
                                Accessories ac3 = new Accessories();
                            carColor3:
                                int cr3 = ac3.Colour();
                                if (cr3 == 5)
                                {
                                    goto carModel3;
                                }
                                cts.colourName = ac3.colourName;
                                cts.colourPrice = ac3.colourPrice;
                                Console.WriteLine("--------------Car Accessories--------------");
                            carCover3:
                                int cover3 = ac3.CarCover();
                                cts.coverPrice = cover3;
                                if (cover3 == 3)
                                {
                                    goto carColor3;
                                }
                            seatCover3:
                                int seatCover3 = ac3.seatCover();
                                cts.seatCoverP = seatCover3;
                                if (seatCover3 == 3)
                                {
                                    goto carCover3;
                                }
                                int floorMat3 = ac3.floorMats();
                                cts.floorMatsP = floorMat3;
                                if (floorMat3 == 3)
                                {
                                    goto seatCover3;
                                }
                                Console.WriteLine();
                                run1 = 1;
                                break;

                            case 4:
                            carModel4:
                                int luxury = ct.Luxury();
                                if (luxury == 5)
                                {
                                    goto cartyPE;
                                }
                                cts.carPrice = ct.carPrice;
                                cts.carName = ct.carName;
                                Accessories ac4 = new Accessories();
                            carColor4:
                                int cr4 = ac4.Colour();
                                if (cr4 == 5)
                                {
                                    goto carModel4;
                                }
                                cts.colourName = ac4.colourName;
                                cts.colourPrice = ac4.colourPrice;
                                Console.WriteLine("--------------Car Accessories--------------");
                            carCover4:
                                int cover4 = ac4.CarCover();
                                cts.coverPrice = cover4;
                                if (cover4 == 3)
                                {
                                    goto carColor4;
                                }
                            seatCover4:
                                int seatCover4 = ac4.seatCover();
                                cts.seatCoverP = seatCover4;
                                if (seatCover4 == 3)
                                {
                                    goto carCover4;
                                }
                                int floorMat4 = ac4.floorMats();
                                cts.floorMatsP = floorMat4;
                                if (floorMat4 == 3)
                                {
                                    goto seatCover4;
                                }
                                Console.WriteLine();
                                run1 = 1;
                                break;

                            default:
                                run1 = 0;
                                Design.ErrorMsg();
                                goto cartyPE;

                        }



                    } while (run1 == 0);
                    int run2 = 0;
                    cts.details();
                    do
                    {

                        Console.WriteLine("Pay on EMI \n 1. YEs 2. NO ");
                        emi = Convert.ToInt32(Console.ReadLine());
                        if (emi == 1)
                        {
                            cts.paidBy = "EMI";
                            Loan emi1 = new Loan();
                            emi1.EMi();
                            int downPayment = cts.totalAmount / 10;
                            cts.downPay = downPayment;
                            Console.WriteLine("Car Down Payment = " + cts.downPay);
                            cts.rateOfInterest = emi1.rate;
                            cts.emiPeriod = emi1.year;
                            Console.WriteLine();
                            Console.WriteLine("---------------EMI---------------");
                            int remainAmount = cts.totalAmount - cts.downPay;
                            int month = cts.emiPeriod * 12;
                            int monthlyBalance = remainAmount / month;
                            int interest = (monthlyBalance * cts.rateOfInterest) / 100;
                            int emiTotal = monthlyBalance + interest;
                            cts.emi = emiTotal;
                            Console.WriteLine("EMI = " + cts.emi);
                        }
                        else if (emi == 2)
                        {
                            cts.paidBy = "Cash / Debit Card / Check ";
                            break;
                        }
                        else
                        {
                            Design.ErrorMsg();
                            emi = 0;

                        }
                    } while (emi == 0);


                    Console.WriteLine();
                    dci[dciPosition].id = id + 1;
                    dci[dciPosition].name = cts.name;
                    dci[dciPosition].gmail = cts.gmail;
                    dci[dciPosition].ph = cts.ph;
                    dci[dciPosition].carName = cts.carName;
                    dci[dciPosition].carPrice = cts.carPrice;
                    dci[dciPosition].colourName = cts.colourName;
                    dci[dciPosition].colourPrice = cts.colourPrice;
                    dci[dciPosition].coverPrice = cts.coverPrice;
                    dci[dciPosition].seatCoverP = cts.seatCoverP;
                    dci[dciPosition].floorMatsP = cts.floorMatsP;
                    dci[dciPosition].rateOfInterest = cts.rateOfInterest;
                    dci[dciPosition].emiPeriod = cts.emiPeriod;
                    dci[dciPosition].totalAmount = cts.totalAmount;
                    dci[dciPosition].downPay = cts.downPay;
                    dci[dciPosition].emi = cts.emi;
                    dci[dciPosition].paidBy = cts.paidBy;
                    dci[dciPosition].carTaxAmount = cts.taxAmount;
                    dciPosition++;
                    cts.FinalDetails();
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Add New Customer ? \n1. Yes   2. No ");
                        run = Convert.ToInt32(Console.ReadLine());

                        if (!(run == 1 || run == 2))
                        {
                            Design.ErrorMsg();
                            run2 = 0;

                        }
                        else
                        {
                            id++;
                            run2 = 1;

                        }
                    } while (run2 == 0);

                } while (run == 1);
                Console.WriteLine();
                int run3 = 0;
                int totalValue = 0;
                do
                {
                    Console.WriteLine("See Daily Report \n1. Yes   2. NO");
                    run3 = Convert.ToInt32(Console.ReadLine());
                    if (run3 == 1)
                    {
                        Console.WriteLine("--------------Daily Report--------------");
                        for (int i = 0; i < id; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ID = " + dci[i].id);
                            Console.WriteLine("Name = " + dci[i].name);
                            Console.WriteLine("Gmail = " + dci[i].gmail);
                            Console.WriteLine("Phone No. = " + dci[i].ph);
                            Console.WriteLine("Car Name = " + dci[i].carName);
                            Console.WriteLine("Car Price = " + dci[i].carPrice);
                            Console.WriteLine("Tax Price 13% of Car Price = " + dci[i].carTaxAmount);
                            Console.WriteLine("Colour Name = " + dci[i].colourName);
                            Console.WriteLine("Colour Price = " + dci[i].colourPrice);
                            if (dci[i].coverPrice != 0)
                            {
                                Console.WriteLine("Cover Price= " + dci[i].coverPrice);

                            }
                            if (dci[i].seatCoverP != 0)
                            {
                                Console.WriteLine("Seat Cover = " + dci[i].seatCoverP);

                            }
                            if (dci[i].floorMatsP != 0)
                            {
                                Console.WriteLine("Floor Mat Price = " + dci[i].floorMatsP);

                            }
                            Console.WriteLine("Total Amount = " + dci[i].totalAmount);
                            Console.WriteLine("Paid BY = " + dci[i].paidBy);
                            if (dci[i].paidBy == "EMI")
                            {
                                Console.WriteLine("Rate of Interest = " + dci[i].rateOfInterest + "%");
                                Console.WriteLine("EMI Period = " + dci[i].emiPeriod);
                                Console.WriteLine("Downpayment = " + dci[i].downPay);
                                Console.WriteLine("EMI = " + dci[i].emi);
                            }
                            totalValue = totalValue + dci[i].totalAmount;
                            Console.WriteLine();


                        }
                        Console.WriteLine("Total Number of Cars Sold Today = " + (id));
                        Console.WriteLine("Total Amount Gain Today = " + totalValue);
                        break;
                    }
                    else if (run3 == 2)
                    {
                        break;
                    }
                    else
                    {
                        Design.ErrorMsg();
                        run3 = 0;
                    }


                } while (run3 == 0);


                Console.WriteLine();
                Console.WriteLine("---------------Thank You---------------");
                Console.ReadLine();


            }

        }

    }
}
