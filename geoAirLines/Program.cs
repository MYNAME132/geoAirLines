using System.Windows.Forms;

namespace geoAirLines
{
    internal static class Program
    {
//        CREATE TABLE[dbo].[UserTb]
//        (
//    [UserId] INT          NOT NULL,
//    [UserName] VARCHAR(50) NOT NULL,
//    [Password] VARCHAR(50) NOT NULL,
//    PRIMARY KEY CLUSTERED([UserId] ASC)
//);
//            CREATE TABLE[dbo].[TicketTable]
//        (
//    [TicketId] INT           NOT NULL,
//    [FlightCode] NVARCHAR(50) NOT NULL,
//    [PassID]      VARCHAR(50)  NOT NULL,
//    [PassName]    VARCHAR(50)  NOT NULL,
//    [Passport]    VARCHAR(50)  NOT NULL,
//    [Gender]      VARCHAR(50)  NOT NULL,
//    [Nationality] VARCHAR(50)  NOT NULL,
//    [PassAdd]     VARCHAR(50)  NOT NULL,
//    [Amount]      VARCHAR(50)  NOT NULL,
//    PRIMARY KEY CLUSTERED([TicketId] ASC)
//);
//            CREATE TABLE[dbo].[PassengerTb]
//        (
//    [PassId] INT           NOT NULL,
//    [PassName] NVARCHAR(50) NOT NULL,
//    [Passport]    NVARCHAR(50) NOT NULL,
//    [PassAd]      NVARCHAR(50) NOT NULL,
//    [Nationality] NVARCHAR(50) NOT NULL,
//    [Gender]      NVARCHAR(50) NOT NULL
//);
//        CREATE TABLE[dbo].[FlightTb]
//        (
//    [FlightCode] NVARCHAR (50) NOT NULL,
//    [Flightsrc]  VARCHAR(50)  NOT NULL,
//    [FlightDes]  VARCHAR(50)  NOT NULL,
//    [FlightDate] VARCHAR(50)  NOT NULL,
//    [Flightcap]  VARCHAR(50)  NOT NULL,
//    PRIMARY KEY CLUSTERED([FlightCode] ASC)
//);


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
}