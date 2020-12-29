namespace SharpVk
{
    public partial class DescriptorSet
    {
        /// <summary>
        ///     Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationBinding">
        ///     The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        ///     The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        ///     A DescriptorType specifying the type of each descriptor in
        ///     bufferInfos.
        ///     It must be the same type as that specified in
        ///     DescriptorSetLayoutBinding for destinationSet at
        ///     destinationBinding. The type of the descriptor also controls which
        ///     array the descriptors are taken from.
        /// </param>
        /// <param name="bufferInfos">
        ///     An array of DescriptorBufferInfo structures.
        /// </param>
        public void WriteDescriptorSet(uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<DescriptorBufferInfo>? bufferInfos)
        {
            Parent.Parent.WriteDescriptorSet(this, destinationBinding, destinationArrayElement, descriptorType, bufferInfos);
        }

        /// <summary>
        ///     Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationBinding">
        ///     The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        ///     The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        ///     A DescriptorType specifying the type of each descriptor in
        ///     imageInfos.
        ///     It must be the same type as that specified in
        ///     DescriptorSetLayoutBinding for destinationSet at
        ///     destinationBinding. The type of the descriptor also controls which
        ///     array the descriptors are taken from.
        /// </param>
        /// <param name="imageInfos">
        ///     An array of DescriptorImageInfo structures.
        /// </param>
        public void WriteDescriptorSet(uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<DescriptorImageInfo>? imageInfos)
        {
            Parent.Parent.WriteDescriptorSet(this, destinationBinding, destinationArrayElement, descriptorType, imageInfos);
        }

        /// <summary>
        ///     Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationBinding">
        ///     The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        ///     The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        ///     A DescriptorType specifying the type of each descriptor in
        ///     texelBufferViews.
        ///     It must be the same type as that specified in
        ///     DescriptorSetLayoutBinding for destinationSet at
        ///     destinationBinding. The type of the descriptor also controls which
        ///     array the descriptors are taken from.
        /// </param>
        /// <param name="texelBufferViews">
        ///     An array of BufferViews.
        /// </param>
        public void WriteDescriptorSet(uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<BufferView>? texelBufferViews)
        {
            Parent.Parent.WriteDescriptorSet(this, destinationBinding, destinationArrayElement, descriptorType, texelBufferViews);
        }
    }
}
