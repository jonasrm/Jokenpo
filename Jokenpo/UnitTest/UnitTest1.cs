using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jokenpo.Classes;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGameDraw()
        {
            Game game = new Game();

            try
            {
                Assert.IsNull(game.CheckWinner(Jokenpo.Classes.Game.Option.Paper, Jokenpo.Classes.Game.Option.Paper));
                Assert.IsNull(game.CheckWinner(Jokenpo.Classes.Game.Option.Rock, Jokenpo.Classes.Game.Option.Rock));
                Assert.IsNull(game.CheckWinner(Jokenpo.Classes.Game.Option.Sissors, Jokenpo.Classes.Game.Option.Sissors));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGamePlayer1Won()
        {
            Game game = new Game();

            try
            {
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Paper, Jokenpo.Classes.Game.Option.Rock), Jokenpo.Classes.Game.Option.Paper);
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Rock, Jokenpo.Classes.Game.Option.Sissors), Jokenpo.Classes.Game.Option.Rock);
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Sissors, Jokenpo.Classes.Game.Option.Paper), Jokenpo.Classes.Game.Option.Sissors);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGamePlayer2Won()
        {
            Game game = new Game();

            try
            {
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Rock, Jokenpo.Classes.Game.Option.Paper), Jokenpo.Classes.Game.Option.Paper);
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Sissors, Jokenpo.Classes.Game.Option.Rock), Jokenpo.Classes.Game.Option.Rock);
                Assert.AreEqual(game.CheckWinner(Jokenpo.Classes.Game.Option.Paper, Jokenpo.Classes.Game.Option.Sissors), Jokenpo.Classes.Game.Option.Sissors);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
