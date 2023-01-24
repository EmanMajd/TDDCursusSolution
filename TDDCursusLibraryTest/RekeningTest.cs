using TDDCursusLibrary;


namespace TDDCursusLibraryTest;

public class RekeningTest
{
    // Het Saldo Van Een Nieuwe Rekening Is Nul
    [TestMethod]
    public void Saldo_NieuwRekening_IsNul()
    {
        // Arrange
        var rekening = new Rekening();

        // Act  

        // Assert
        Assert.AreEqual(decimal.Zero, rekening.Saldo);
    }

    // Het Saldo Na Een Eerste Storting Is Het Bedrag Van Die Storting
    [TestMethod]
    public void Saldo_NaEersteStorting_BedragVanDeStorting()
    {
        // Arrange
        var rekening = new Rekening();
        var bedrag = 2.5m;

        // Act
        rekening.Storten(bedrag);

        // Assert
        Assert.AreEqual(bedrag, rekening.Saldo);
    }

    // Het Saldo Na Twee Stortingen Is De Som Van De Bedragen Van Die Stortingen
    [TestMethod]
    public void Saldo_NaTweeStortingen_SomVanDeStortingen()
    {

        // Arrange
        var rekening = new Rekening();

        // Act
        rekening.Storten(2.5m);
        rekening.Storten(1.2m);

        // Assert
        Assert.AreEqual(3.7m, rekening.Saldo);
    }
}
