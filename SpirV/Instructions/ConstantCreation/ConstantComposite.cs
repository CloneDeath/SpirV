using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.ConstantCreation
{
    /// <summary>
    /// Declare a new composite constant.
    /// Constituents will become members of a structure, or elements of an array, or components of a vector, or columns of a
    /// matrix.There must be exactly one Constituent for each top-level member/element/component/column of the result.
    /// The Constituents must appear in the order needed by the definition of the Result Type. The Constituents must all be
    /// <id> s of other constant declarations or an OpUndef.
    /// </summary>
	public class ConstantComposite : BaseInstruction
    {
        public ConstantComposite(int resultTypeId, int resultId, params int[] constituents) {
            ResultTypeId = resultTypeId;
            ResultId = resultId;
            Constituents = constituents;
        }

        public override int WordCount => 3 + Constituents.Length;
        public override Operation OpCode => Operation.ConstantComposite;

        /// <summary>
        /// Result Type must be a composite type, whose top-level members/elements/components/columns have the same type
        /// as the types of the Constituents. The ordering must be the same between the top-level types in Result Type and the
        /// Constituents.
        /// </summary>
        public int ResultTypeId { get; set; }
        public int ResultId { get; set; }

        /// <summary>
        /// Constituents will become members of a structure, or elements of an array, or components of a vector, or columns of a
        /// matrix. There must be exactly one Constituent for each top-level member/element/component/column of the result.
        /// The Constituents must appear in the order needed by the definition of the Result Type. The Constituents must all be
        /// ids of other constant declarations or an OpUndef.
        /// </summary>
        public int[] Constituents { get; set; }

        protected override byte[] GetParameterBytes() {
            var byteArray = new ByteArray();
            byteArray.PushUInt32((uint)ResultTypeId);
            byteArray.PushUInt32((uint)ResultId);
            foreach (var value in Constituents)
            {
                byteArray.PushUInt32((uint)value);
            }
            return byteArray.ToArray();
        }
	}
}
