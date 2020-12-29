namespace SharpVk
{
    public partial class DescriptorPool
    {
        /// <summary>
        ///     Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="setLayout">
        /// </param>
        public DescriptorSet AllocateDescriptorSet(DescriptorSetLayout setLayout)
        {
            return parent.AllocateDescriptorSet(this, setLayout);
        }

        /// <summary>
        ///     Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="setLayouts">
        /// </param>
        public DescriptorSet[] AllocateDescriptorSets(ArrayProxy<DescriptorSetLayout> setLayouts)
        {
            return parent.AllocateDescriptorSets(this, setLayouts);
        }
    }
}