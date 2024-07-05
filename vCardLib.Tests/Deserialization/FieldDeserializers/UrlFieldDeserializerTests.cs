using NUnit.Framework;
using Shouldly;
using vCardLib.Deserialization.FieldDeserializers;
using vCardLib.Deserialization.Interfaces;

namespace vCardLib.Tests.Deserialization.FieldDeserializers
{
    [TestFixture]
    public class UrlFieldDeserializerTests
    {
        [Test]
        public void V2ShouldParseSimple() 
        {
            const string input = "URL:www.acme.com";
            IV2FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V2ShouldParseWithMetadataWithTypeKeyword() 
        {
            const string input = "URL;type=WORK:www.acme.com";
            IV2FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V2ShouldParseWithMetadataWithoutTypeKeyword() 
        {
            const string input = "URL;WORK:www.acme.com";
            IV2FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V3ShouldParseSimple() 
        {
            const string input = "URL:www.acme.com";
            IV4FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V3ShouldParseWithMetadataWithTypeKeyword() 
        {
            const string input = "URL;type=WORK:www.acme.com";
            IV3FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V3ShouldParseWithMetadataWithoutTypeKeyword() 
        {
            const string input = "URL;WORK:www.acme.com";
            IV3FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V4ShouldParseSimple() 
        {
            const string input = "URL:www.acme.com";
            IV3FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }


        [Test]
        public void V4ShouldParseWithMetadataWithTypeKeyword() 
        {
            const string input = "URL;type=WORK:www.acme.com";
            IV4FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }

        [Test]
        public void V4ShouldParseWithMetadataWithoutTypeKeyword() 
        {
            const string input = "URL;WORK:www.acme.com";
            IV4FieldDeserializer<string> deserializer = new UrlFieldDeserializer();
            var result = deserializer.Read(input);

            result.ShouldBe("www.acme.com");
        }
    }
}