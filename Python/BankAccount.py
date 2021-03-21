class BankAccount:
    ___dep_name = " "
    acno = " "
    actype = ""
    balance = 0.0

    def menu(self):
        print ("What do you want to do:")
        print ("1. Deposit")
        print ("2. Withdraw")
        print ("3. Display Balance")
        print ("4. Exit")
        ch = int(input ("Enter you choice:"))

        if ch==1:
            self.deposit()
        elif ch==2:
            self.withdraw()
        elif ch==3:
            self.display()
        elif ch==4:
            print("Thank you!")
        else:
            print ("Invalid option!")
            self.menu()

    def __init__(self):
        self.__dep_name = "Ritik"
        self.acno = 123
        self.actype = "SA"
        self.balance = 10000.00
    
    def deposit(self):
        amount = float(input("Enter amount to deposit: "))
        self.balance = self.balance + amount
        self.menu()

    def withdraw(self):
        amount =  float(input("Enter amount to withdraw: "))
        if amount <= self.balance:
            self.balance = self.balance - amount
        else:
            print ("Transaction Declined!")
        self.menu()

    def display(self):
        print ("Account #: ",self.acno)
        print ("Depositor Name: ",self.__dep_name)
        print ("Account Type: ",self.actype)
        print ("Balance: ",self.balance)
        self.menu()

acc = BankAccount()
#acc.init()
#acc.__dep_name = "Banty Kumar"     Need more citation
acc.menu()