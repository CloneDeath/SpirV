using FluentAssertions;
using Xunit;

namespace SpirV.Tests
{
    public class ByteArrayTests
    {
	    [Theory]
	    [InlineData("hello world", 3)]
		[InlineData("", 1)]
		[InlineData("abc", 1)]
		[InlineData("abcd", 2)]
		[InlineData("abcdefg", 2)]
		[InlineData("abcdefgh", 3)]
		public void GetWordCountCorrectlyCalculatesTheWordCount(string input, int length) {
			ByteArray.GetWordCount(input).Should().Be(length);
		}

	    [Fact]
		public void PushStringZeroPadsResults() {
			var byteArray = new ByteArray();
			byteArray.PushString("helo");
			var array = byteArray.ToArray();
			array.Should().HaveCount(8);
			array[0].Should().Be((int)'h');
			array[1].Should().Be((int)'e');
			array[2].Should().Be((int)'l');
			array[3].Should().Be((int)'o');
			array[4].Should().Be(0);
			array[5].Should().Be(0);
			array[6].Should().Be(0);
			array[7].Should().Be(0);
		}
    }
}
