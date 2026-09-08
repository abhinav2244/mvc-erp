
using Microsoft.EntityFrameworkCore;
using mvc_erp.Models;

namespace mvc_erp.Services
{
    // LoginService contains all login-related database operations.
    //
    // We keep database logic inside a service instead of putting it
    // directly inside AccountController. This keeps the controller
    // clean and separates responsibilities.
    public class LoginService
    {
        // ErpDbContext is our EF Core DbContext.
        //
        // It provides access to the SQL Server database and allows us
        // to execute EF Core queries and existing stored procedures.
        private readonly ErpDbContext _context;


        // Constructor of LoginService.
        //
        // ErpDbContext is provided automatically by ASP.NET Core
        // Dependency Injection.
        //
        // We don't create "new ErpDbContext()" manually here.
        public LoginService(ErpDbContext context)
        {
            _context = context;
        }


        // This method gets the login information for the given username.
        //
        // It calls your existing Select_LoginId stored procedure
        // through EF Core.
        //
        // The method is asynchronous because database operations
        // can take time, and we don't want to block the web server
        // while waiting for SQL Server.
        public async Task<List<LoginUser>> GetLoginUserAsync(string username)
        {
            // Execute the existing stored procedure through EF Core.
            //
            // SqlQuery<LoginUser>() tells EF Core that the result
            // returned by SQL Server should be mapped to LoginUser.
            //
            // We are NOT using ADO.NET here.
            //
            // {username} is parameterized by EF Core, which means
            // we are not directly concatenating user input into SQL.
            var users = await _context.Database
                .SqlQuery<LoginUser>(
                    $"EXEC dbo.Select_LoginId @Log_User_Id = {username}")
                .ToListAsync();


            // Return the list of users returned by the stored procedure.
            return users;
        }
    }


    // LoginUser represents the result returned by Select_LoginId.
    //
    // This is a result/DTO class.
    //
    // It is NOT a database table and we do not need to add
    // a DbSet<LoginUser> inside ErpDbContext.
    //
    // It simply tells EF Core what columns we expect from
    // the stored procedure result.
    //public class LoginUser
    //{
      
    //    public int Id { get; set; }
    //    public string? UserLogin { get; set; }

    //    // We will use this later for password verification.
    //    // For now, we are only retrieving it from the database.
    //    public string? Password1 { get; set; }

    //    // This identifies the category/type of the user.
    //    //
    //    // Your stored procedure handles different user categories,
    //    // such as Admin, Student, Employee and Exam Teacher.
    //    public string? Specategory { get; set; }

    //    // This can represent the student's ID, teacher ID,
    //    // employee-related ID, etc., depending on the user category.
    //    public int? IDNumber { get; set; }

    //    // Students can have a photo returned from idcarddetails.
    //    public byte[]? StudPhoto { get; set; }

    //    // For students this contains the student's first name.
    //    // For some other categories, your stored procedure returns
    //    // the username instead.
    //    public string? StudFirstName { get; set; }

    //    // Contains the branch associated with the user.
    //    public string? BranchCode { get; set; }

    //    // Indicates whether the user's account is locked.
    //    public bool IsLock { get; set; }

    //    // This will be used later if your login process checks
    //    // the system lock date.
    //    public string? FromDate { get; set; }

    //    // This will be used later if your login process checks
    //    // the system lock date.
    //    public string? ToDate { get; set; }
    //}

   
public class LoginUser
    {
        public int Id { get; set; }

        public string? UserLogin { get; set; }

        public string? Password1 { get; set; }

        public string? Specategory { get; set; }

        public int? IDNumber { get; set; }

        public bool IsLock { get; set; }
    }


}

