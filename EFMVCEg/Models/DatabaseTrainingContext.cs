using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFMVCEg.Models
{
    public partial class DatabaseTrainingContext : DbContext
    {
        public DatabaseTrainingContext()
        {
        }

        public DatabaseTrainingContext(DbContextOptions<DatabaseTrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AjayEmployee> AjayEmployees { get; set; }
        public virtual DbSet<AjaySbaccount> AjaySbaccounts { get; set; }
        public virtual DbSet<AjaySbtransaction1> AjaySbtransaction1s { get; set; }
        public virtual DbSet<AvinashSbaccount> AvinashSbaccounts { get; set; }
        public virtual DbSet<AvinashSbtransaction> AvinashSbtransactions { get; set; }
        public virtual DbSet<BhramarSbaccount> BhramarSbaccounts { get; set; }
        public virtual DbSet<BhramarSbtransaction> BhramarSbtransactions { get; set; }
        public virtual DbSet<DarshanSbaccount> DarshanSbaccounts { get; set; }
        public virtual DbSet<DarshanSbtransaction> DarshanSbtransactions { get; set; }
        public virtual DbSet<DivyanshSbaccount> DivyanshSbaccounts { get; set; }
        public virtual DbSet<DivyanshSbtransaction> DivyanshSbtransactions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Harish1> Harish1s { get; set; }
        public virtual DbSet<HarishSbaccount> HarishSbaccounts { get; set; }
        public virtual DbSet<HarishSbtransaction> HarishSbtransactions { get; set; }
        public virtual DbSet<HarshSbaccount> HarshSbaccounts { get; set; }
        public virtual DbSet<HarshSbtransaction> HarshSbtransactions { get; set; }
        public virtual DbSet<JivikaSbaccount> JivikaSbaccounts { get; set; }
        public virtual DbSet<JivikaSbtransaction> JivikaSbtransactions { get; set; }
        public virtual DbSet<JivikaTable> JivikaTables { get; set; }
        public virtual DbSet<LekhanaSbacc> LekhanaSbaccs { get; set; }
        public virtual DbSet<LekhanaSbtran> LekhanaSbtrans { get; set; }
        public virtual DbSet<Manisha> Manishas { get; set; }
        public virtual DbSet<ManishaSbaccount> ManishaSbaccounts { get; set; }
        public virtual DbSet<ManishaSbtransaction> ManishaSbtransactions { get; set; }
        public virtual DbSet<RaviSbaccount> RaviSbaccounts { get; set; }
        public virtual DbSet<RaviSbtransaction> RaviSbtransactions { get; set; }
        public virtual DbSet<RitikSbacoount> RitikSbacoounts { get; set; }
        public virtual DbSet<RitikSbtransaction> RitikSbtransactions { get; set; }
        public virtual DbSet<SarwatSbaccount> SarwatSbaccounts { get; set; }
        public virtual DbSet<SarwatSbtransaction> SarwatSbtransactions { get; set; }
        public virtual DbSet<SbAccountYash> SbAccountYashes { get; set; }
        public virtual DbSet<SbLoan> SbLoans { get; set; }
        public virtual DbSet<SbTransactionYash> SbTransactionYashes { get; set; }
        public virtual DbSet<SbaccountAbhishek> SbaccountAbhisheks { get; set; }
        public virtual DbSet<SbaccountAmresh> SbaccountAmreshes { get; set; }
        public virtual DbSet<SbaccountSankalp> SbaccountSankalps { get; set; }
        public virtual DbSet<SbaccountShaifali> SbaccountShaifalis { get; set; }
        public virtual DbSet<SbtransactionAbhishek> SbtransactionAbhisheks { get; set; }
        public virtual DbSet<SbtransactionAmresh> SbtransactionAmreshes { get; set; }
        public virtual DbSet<SbtransactionSankalp> SbtransactionSankalps { get; set; }
        public virtual DbSet<SbtransactionShaifali> SbtransactionShaifalis { get; set; }
        public virtual DbSet<ShanSbaccount> ShanSbaccounts { get; set; }
        public virtual DbSet<ShanSbtransaction> ShanSbtransactions { get; set; }
        public virtual DbSet<Shivam> Shivams { get; set; }
        public virtual DbSet<Shivamsbaccount> Shivamsbaccounts { get; set; }
        public virtual DbSet<Shivamsbtransaction> Shivamsbtransactions { get; set; }
        public virtual DbSet<SundaramSbaccount> SundaramSbaccounts { get; set; }
        public virtual DbSet<SundaramSbtransaction> SundaramSbtransactions { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TrasferFund> TrasferFunds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.22.10.31;Database=DatabaseTraining;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AjayEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ajay_Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<AjaySbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ajay_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance).HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.MaxBalance).HasColumnName("maxBalance");
            });

            modelBuilder.Entity<AjaySbtransaction1>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ajay_SBTransaction1");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionId");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<AvinashSbaccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Avinash_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Account_number");

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Current_Balance");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AvinashSbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Avinash_SBTransaction");

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransactionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BhramarSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Bhramar_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CurrentAddress)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhramarSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Bhramar_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DarshanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("darshanSBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customerName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DarshanSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("darshanSBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .HasColumnName("transactionId")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DivyanshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Divyansh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.Currentbalance).HasColumnName("currentbalance");

                entity.Property(e => e.Customeraddress)
                    .HasMaxLength(50)
                    .HasColumnName("customeraddress");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customername");
            });

            modelBuilder.Entity<DivyanshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid);

                entity.ToTable("Divyansh_SBTransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Accountnumber).HasColumnName("accountnumber");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("date")
                    .HasColumnName("transactiondate");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Doj).HasColumnType("date");

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<Harish1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("harish_1");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(10)
                    .HasColumnName("employee_name")
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeNumber).HasColumnName("employee_number");
            });

            modelBuilder.Entity<HarishSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("harish_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarishSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.ToTable("harish_SBTransaction");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("t_type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HarshSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Harsh_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<HarshSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Harsh_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).HasMaxLength(20);
            });

            modelBuilder.Entity<JivikaSbaccount>(entity =>
            {
                entity.ToTable("Jivika_SBAccount");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("customer_address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .HasColumnName("customer_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<JivikaSbtransaction>(entity =>
            {
                entity.ToTable("Jivika_SBTransaction");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountNo).HasColumnName("account_no");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Dot)
                    .HasColumnType("datetime")
                    .HasColumnName("dot");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<JivikaTable>(entity =>
            {
                entity.ToTable("JivikaTable");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LekhanaSbacc>(entity =>
            {
                entity.HasKey(e => e.AccNumber)
                    .HasName("PK__Lekhana___A24910AB202506CF");

                entity.ToTable("Lekhana_SBAcc");

                entity.Property(e => e.AccNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("acc_number");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LekhanaSbtran>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("PK_Lekhana_sbtran");

                entity.ToTable("Lekhana_SBTran");

                entity.Property(e => e.TId)
                    .ValueGeneratedNever()
                    .HasColumnName("t_id");

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Amt).HasColumnName("amt");

                entity.Property(e => e.TDate)
                    .HasColumnType("date")
                    .HasColumnName("t_date");

                entity.Property(e => e.TType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t_type");
            });

            modelBuilder.Entity<Manisha>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Manisha");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<ManishaSbaccount>(entity =>
            {
                entity.HasKey(e => e.Accno);

                entity.ToTable("Manisha_SBAccount");

                entity.Property(e => e.Accno).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishaSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("Manisha_SBTransaction");

                entity.Property(e => e.TransId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransID");

                entity.Property(e => e.Amt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaviSbaccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ravi_SBAccount");

                entity.Property(e => e.AccountNo).HasColumnName("Account No");

                entity.Property(e => e.CurrentBalance).HasColumnName("Current balance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(10)
                    .HasColumnName("Customer Address")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<RaviSbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ravi_SBTransaction");

                entity.Property(e => e.AccountNo).HasColumnName("Account No");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction Id");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("Transaction Type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RitikSbacoount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Ritik_SBAcoount");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.CurrentBalance).HasMaxLength(50);

                entity.Property(e => e.CustomerAddress).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<RitikSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ritik_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasMaxLength(50);

                entity.Property(e => e.TransactionType).HasMaxLength(50);
            });

            modelBuilder.Entity<SarwatSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Sarwat_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SarwatSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Sarwat_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbAccountYash>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SB_Account_Yash");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Current Balance");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Address");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");
            });

            modelBuilder.Entity<SbLoan>(entity =>
            {
                entity.ToTable("sbLoan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DurationInDays).HasColumnName("durationInDays");

                entity.Property(e => e.Intrest).HasColumnName("intrest");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            modelBuilder.Entity<SbTransactionYash>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SB_Transaction_Yash");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Transaction ID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Account Number");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<SbaccountAbhishek>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("AccNo");

                entity.ToTable("SBAccount_Abhishek");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountAmresh>(entity =>
            {
                entity.HasKey(e => e.AccNo);

                entity.ToTable("SBAccount_Amresh");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SbaccountSankalp>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SBAccount_sankalp");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CreditScore).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbaccountShaifali>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("SBAccount_Shaifali");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SbtransactionAbhishek>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("TransactionId");

                entity.ToTable("SBTransaction_Abhishek");

                entity.Property(e => e.TransactionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccountNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionAmresh>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Amresh");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionSankalp>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_sankalp");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbtransactionShaifali>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("SBTransaction_Shaifali");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ShanSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("shan_SBAccount");

                entity.Property(e => e.AccountNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("accountNumber");

                entity.Property(e => e.CurrentBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currentBalance");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .HasColumnName("customerAddress");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customerName");
            });

            modelBuilder.Entity<ShanSbtransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shan_SBTransaction");

                entity.Property(e => e.AccountNumber).HasColumnName("accountNumber");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionId).HasColumnName("transactionID");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .HasColumnName("transactionType");
            });

            modelBuilder.Entity<Shivam>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_shivam_1");

                entity.ToTable("shivam");

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbaccount>(entity =>
            {
                entity.HasKey(e => e.Accountnumber);

                entity.ToTable("shivamsbaccount");

                entity.Property(e => e.Accountnumber).ValueGeneratedNever();

                entity.Property(e => e.Customeraddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivamsbtransaction>(entity =>
            {
                entity.HasKey(e => e.Transactionid)
                    .HasName("PK_shivamsbtransaction_1");

                entity.ToTable("shivamsbtransaction");

                entity.Property(e => e.Transactionid)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("transactiontype")
                    .IsFixedLength(true);

                entity.Property(e => e.Transationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("transationdate");
            });

            modelBuilder.Entity<SundaramSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("sundaram_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SundaramSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("sundaram_SBTransaction");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TrasferFund>(entity =>
            {
                entity.ToTable("trasferFunds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.FromAccount).HasColumnName("fromAccount");

                entity.Property(e => e.ToAccount).HasColumnName("toAccount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
