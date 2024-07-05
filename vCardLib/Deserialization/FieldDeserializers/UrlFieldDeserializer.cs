using vCardLib.Deserialization.Interfaces;
using vCardLib.Deserialization.Utilities;

namespace vCardLib.Deserialization.FieldDeserializers;

internal sealed class UrlFieldDeserializer : IV2FieldDeserializer<string>, IV3FieldDeserializer<string>,
    IV4FieldDeserializer<string>
{
    public static string FieldKey => "URL";

    public string Read(string input) {
        var (metadata, value) = DataSplitHelpers.SplitLine(FieldKey, input);
        return value;
    }
}