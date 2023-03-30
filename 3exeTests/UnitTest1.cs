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
                "��������� ��������\r\n������� ����� ���������\r\n��������� ��������\r\n������� ����� ���������\r\n������� ����� ���������\r\n��������� ��������\r\n������� ����� ���������\r\n������� ����� ���������\r\n������� ����� ���������\r\n��������� ��� �������� � 3 �����������\r\n������� ����� ���������\r\n������� ����� ���������\r\n������� ����� ���������\r\n������� ����� ���������\r\n",
                res);
        }
    }
}