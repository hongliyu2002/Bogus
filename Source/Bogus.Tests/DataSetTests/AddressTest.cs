using Bogus.DataSets;
using FluentAssertions;
using Xunit;

namespace Bogus.Tests.DataSetTests
{
    public class AddressTest : SeededTest
    {
        public AddressTest()
        {
            address = new Address();
        }

        private readonly Address address;

        [Fact]
        public void can_get_a_city_name()
        {
            address.City().Should().Be("Bernhardfort");
        }

        [Fact]
        public void can_get_a_country()
        {
            address.Country().Should().Be("Mozambique");
        }

        [Fact]
        public void can_get_a_county()
        {
            address.County().Should().Be("Borders");
        }

        [Fact]
        public void can_get_a_full_address()
        {
            address.FullAddress().Should().Be("60643 Oberbrunner Bypass, Danielchester, Monaco");
        }

        [Fact]
        public void can_get_a_full_street_address()
        {
            address.StreetAddress(true).Should().Be("60643 Oberbrunner Bypass Suite 175");
        }

        [Fact]
        public void can_get_a_latitude()
        {
            address.Latitude().Should().Be(18.634);
        }

        [Fact]
        public void can_get_a_longitude()
        {
            address.Latitude().Should().Be(18.634);
        }

        [Fact]
        public void can_get_a_random_country_code()
        {
            address.CountryCode().Should().Be("MQ");
        }

        [Fact]
        public void can_get_a_state()
        {
            address.State().Should().Be("New Mexico");
        }

        [Fact]
        public void can_get_a_state_abbreviation()
        {
            address.StateAbbr().Should().Be("NM");
        }

        [Fact]
        public void can_get_a_street_address()
        {
            address.StreetAddress().Should().Be("60643 Oberbrunner Bypass");
        }

        [Fact]
        public void can_get_a_street_suffix()
        {
            address.StreetSuffix().Should().Be("Pines");
        }

        [Fact]
        public void can_get_a_zipcode()
        {
            address.ZipCode().Should().Be("18606-0643");
        }

        [Fact]
        public void can_get_canadian_zip_code()
        {
            var a = new Address("en_CA");
            a.ZipCode().Should().Be("C8Q 0Q0");
        }
    }
}