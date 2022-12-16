using System;
using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new specialization constant that results from doing an operation.
	/// </summary>
	public class SpecConstantOp : BaseInstruction {
		public override int WordCount => 4 + Operands.Length;
		public override Operation OpCode => Operation.SpecConstantOp;
		
		/// <summary>
		/// Result Type must be the type required by the Result Type of Opcode.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Opcode must be one of the following opcodes. This literal operand is limited to a single word.
		/// OpSConvert, OpFConvert
		/// OpSNegate, OpNot
		/// OpIAdd, OpISub
		/// OpIMul, OpUDiv, OpSDiv, OpUMod, OpSRem, OpSMod
		/// OpShiftRightLogical, OpShiftRightArithmetic, OpShiftLeftLogical
		/// OpBitwiseOr, OpBitwiseXor, OpBitwiseAnd
		/// OpVectorShuffle, OpCompositeExtract, OpCompositeInsert
		/// OpLogicalOr, OpLogicalAnd, OpLogicalNot,
		/// OpLogicalEqual, OpLogicalNotEqual
		/// OpSelect
		/// OpIEqual, OpINotEqual
		/// OpULessThan, OpSLessThan
		/// OpUGreaterThan, OpSGreaterThan
		/// OpULessThanEqual, OpSLessThanEqual
		/// OpUGreaterThanEqual, OpSGreaterThanEqual
		/// 
		/// If the Shader capability was declared, the following opcode is also valid:
		/// OpQuantizeToF16
		/// 
		/// If the Kernel capability was declared, the following opcodes are also valid:
		/// OpConvertFToS, OpConvertSToF
		/// OpConvertFToU, OpConvertUToF
		/// OpUConvert
		/// OpConvertPtrToU, OpConvertUToPtr
		/// OpGenericCastToPtr, OpPtrCastToGeneric
		/// OpBitcast
		/// OpFNegate
		/// OpFAdd, OpFSub
		/// OpFMul, OpFDiv
		/// OpFRem, OpFMod
		/// OpAccessChain, OpInBoundsAccessChain
		/// OpPtrAccessChain, OpInBoundsPtrAccessChain
		/// </summary>
		public Operation Operation { get; set; }
		
		/// <summary>
		/// Operands are the operands required by opcode, and satisfy the semantics of opcode.
		/// In addition, all Operands must be either:
		/// - the &lt;id&gt;s of other constant instructions, or
		/// - OpUndef, when allowed by opcode, or
		/// - for the AccessChain named opcodes, their Base is allowed to be a global (module scope)
		/// OpVariable instruction.
		/// </summary>
		public int[] Operands { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) Operation);
			foreach (var operand in Operands) {
				byteArray.PushUInt32((uint) operand);
			}
			return byteArray.ToArray();
		}
	}
}
