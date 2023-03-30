using HW15_3exe;
namespace _3exeTests
{
    [TestClass]
    public class _3exeTests
    {
        [TestMethod]
        public void RunTest()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Task.Run(ThreeExe.RunProgram);
            Thread.Sleep(500);
            Task.Run(ThreeExe.RunProgram);
            Thread.Sleep(500);
            Task.Run(ThreeExe.RunProgram);
            Thread.Sleep(500);
            Task.Run(ThreeExe.RunProgram);
            Thread.Sleep(500);

            var res = stringWriter.ToString();
            Assert.AreEqual(
                "программа запущена\r\nзапущен новый экземпл€р\r\nпрограмма запущена\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\nпрограмма запущена\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\nпрограмма уже запущена в 3 экземпл€рах\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\nзапущен новый экземпл€р\r\n",
                res);
        }
    }
}