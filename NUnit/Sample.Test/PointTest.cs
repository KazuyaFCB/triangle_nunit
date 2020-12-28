using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Sample.Test
{
    [TestFixture] // dùng để đánh dấu lớp PointTest sẽ là các đơn vị kiểm thử (unit tests)
    public class PointTest
    {
        private Point _p;

        [SetUp] // khởi tạo biến _p
        public void Setup()
        {
            _p = new Point();
        }

        [Test] // dùng để đánh dấu mỗi phương thức bên dưới sẽ là các đơn vị kiểm thử (unit tests)
        public void TwoPointOnEachSideHavePositiveCoordinate()
        {
            _p.X = 17;
            _p.Y = 5;
            // Phương thức AreEqual:
            // Tham số 1: Kết quả mong đợi
            // Tham số 2: Kết quả thực tế
            // Tham số 3: Tin nhắn khi có lỗi
            Assert.AreEqual(Math.Sqrt(13), _p.GetDistance(new Point(19, 2)), "2 điểm có tọa độ dương");
        }
        [Test]
        public void TwoPointOnEachSideHaveNegativeCoordinate()
        {
            _p.X = -17;
            _p.Y = -5;
            Assert.AreEqual(Math.Sqrt(13), _p.GetDistance(new Point(-19, -2)), "2 điểm có tọa độ âm");
        }
        [Test]
        public void EachPointHasPositiveAndNegativeCoordinate()
        {
            _p.X = 17;
            _p.Y = -5;
            Assert.AreEqual(Math.Sqrt(13), _p.GetDistance(new Point(19, -2)), "2 điểm có tọa độ dương và âm");
        }
        [Test]
        public void TwoPointOverlapEachOther()
        {
            _p.X = 1;
            _p.Y = 2;
            Assert.AreEqual(0, _p.GetDistance(new Point(1, 2)), "2 điểm có tọa độ trùng nhau");
        }
        [Test]
        public void CoordinateHasInvalidInput()
        {
            _p.X = 3;
            _p.Y = 4;
            Assert.AreEqual(-1, _p.GetDistance(new Point(0, 'x')), "Điểm có tọa độ là chữ");
        }
    }
}
