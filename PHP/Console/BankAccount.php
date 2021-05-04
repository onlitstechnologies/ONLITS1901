<?php

class BankAccount
{
    private $dep_name;
    private $acno;
    private $actype;
    private $balance;

    function menu()
    {
        echo ("What do you want to do:\n");
        echo ("1. Deposit\n");
        echo ("2. Withdraw\n");
        echo ("3. Display Balance\n");
        echo ("4. Exit\n");
        echo ("Enter you choice:");
        $ch = readline();
        switch ($ch) {
            case 1:
                $this->deposit();
                break;
            case 2:
                $this->withdraw();
                break;
            case 3:
                $this->display();
                break;
            case 4:
                break;
            default:
                echo ("Invalid option!");
                $this->menu();
                break;
        }
    }

    function init()
    {
        $this->dep_name = "Ritik";
        $this->acno = 123;
        $this->actype = "SA";
        $this->balance = 10000.00;
    }

    function deposit()
    {
        echo ("Enter amount to deposit: ");
        $this->amount = readline();
        $this->balance = $this->balance + $this->amount;
        $this->menu();
    }

    function withdraw()
    {
        echo ("Enter amount to withdraw: ");
        $this->amount = readline();
        if ($this->amount <= $this->balance)
        $this->balance = $this->balance - $this->amount;
        else
            echo ("Transaction Declined!");
        $this->menu();
    }

    function display()
    {
        echo ("Account #: $this->acno\n");
        echo ("Depositor Name: $this->dep_name\n");
        echo ("Account Type: $this->actype\n");
        echo ("Balance: $this->balance\n");
        $this->menu();
    }
}


$acc = new BankAccount();
$acc->init();
$acc->menu();


//Scaffolding
