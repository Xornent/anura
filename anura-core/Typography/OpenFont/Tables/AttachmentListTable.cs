using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class AttachmentListTable {
        private struct AttachPoint {
            public ushort[] pointIndices;
        }

        private AttachPoint[] _attachPoints;

        public CoverageTable CoverageTable {
            get;
            private set;
        }

        public static AttachmentListTable CreateFrom (BinaryReader reader, long beginAt) {
            AttachmentListTable attachmentListTable = new AttachmentListTable ();
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort[] array = Utils.ReadUInt16Array (reader, num2);
            attachmentListTable.CoverageTable = CoverageTable.CreateFrom (reader, beginAt + num);
            attachmentListTable._attachPoints = new AttachPoint[num2];
            for (int i = 0; i < num2; i++) {
                reader.BaseStream.Seek (beginAt + array[i], SeekOrigin.Begin);
                ushort nRecords = reader.ReadUInt16 ();
                attachmentListTable._attachPoints[i] = new AttachPoint {
                    pointIndices = Utils.ReadUInt16Array (reader, nRecords)
                };
            }
            return attachmentListTable;
        }
    }
}