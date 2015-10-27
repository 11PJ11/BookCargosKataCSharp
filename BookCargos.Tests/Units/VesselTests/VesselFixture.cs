using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.VesselTests
{
    [TestFixture]
    public class VesselFixture
    {
        protected Vessel Vessel;
        protected ICargos Cargos = Substitute.For<ICargos>();
        protected INotifications Notifications = Substitute.For<INotifications>();
        
        protected readonly CubicFeet TWENTY_CUBIC_FEET = new CubicFeet(20);
        protected readonly CubicFeet ONE_THOUSAND_CUBIC_FEET = new CubicFeet(1000);

        [SetUp]
        public void Setup()
        {
            Vessel = CreateAVessel();
        }

        protected Vessel CreateAVessel()
        {
            return VesselBuilder
                .AVessel()
                .WithCapacity(ONE_THOUSAND_CUBIC_FEET)
                .Transporting(Cargos)
                .NotifyingWith(Notifications)
                .Build();
        }
    }
}
