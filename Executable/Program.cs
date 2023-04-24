// See https://aka.ms/new-console-template for more information

using ChainOfResponsability;
using ChainOfResponsability.Exercise;
using Domain;

GenerateChain generateChain = new GenerateChain();

BankAccount bankAccount = new BankAccount(500, "My Name");

string format = generateChain.Generate(Format.CSV, bankAccount);

Console.WriteLine(format);

//DiscountCalculator calculator = new DiscountCalculator();

//Buget buget  = new Buget(500);

//buget.AddItem(new Item("Pen", 250));
//buget.AddItem(new Item("Pencil", 250));

//double discount = calculator.Calculate(buget);

//Console.WriteLine(discount);

//ITax iss = new ISS();
//ITax icms = new ICMS();

//Buget buget = new Buget(500.0);

//TaxesCalculator taxesCalculator = new TaxesCalculator();

//// Calculate ISS
//taxesCalculator.DoCaltulation(buget, iss);

//// Calculate ICMS
//taxesCalculator.DoCaltulation(buget, icms);


//ITax iccc = new ICCC();
//TaxesCalculator taxesCalculator = new TaxesCalculator();

//List<Buget> bugetList = new List<Buget>();

//// Calculate ICCC
//bugetList.Add(new Buget(1000.0));
//bugetList.Add(new Buget(999.0));
//bugetList.Add(new Buget(3001.0));
//bugetList.Add(new Buget(3000.0));

//foreach (var item in bugetList)
//{
//	iccc.Calculate(item);
//}

//BankAccount bankAccount = new BankAccount();
//bankAccount.Balance = 10000.00;

//IInvest conservative = new Conservative();
//IInvest moderate = new Moderate();
//IInvest bold = new Bold();

//InvestmentMaker investmentMaker = new InvestmentMaker();

//bankAccount.Balance += investmentMaker.Invest(conservative, 5000);
//bankAccount.Balance += investmentMaker.Invest(moderate, 3000);
//bankAccount.Balance += investmentMaker.Invest(bold, 2000);

//Console.WriteLine(bankAccount.Balance);
