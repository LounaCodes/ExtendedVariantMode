namespace ExtendedVariants.Variants;

public class ConsistentRNG : AbstractExtendedVariant {
    public ConsistentRNG() : base(variantType: typeof(bool), defaultVariantValue: false) { }

    public override object ConvertLegacyVariantValue(int value) {
        return value != 0;
    }

}
