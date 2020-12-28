using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Sample.Test
{
    [TestFixture] // dùng để đánh dấu lớp TriangleTest sẽ là các đơn vị kiểm thử (unit tests)
    public class TriangleTest
    {
        private Triangle _t;
        [SetUp] // khởi tạo biến _t
        public void Setup()
        {
            _t = new Triangle();
        }

        [Test] // dùng để đánh dấu mỗi phương thức bên dưới sẽ là các đơn vị kiểm thử (unit tests)
        public void ThreePointsOverlapEachOther()
        {
            _t = new Triangle(new Point(0, 0), new Point(0,0), new Point(0,0));
            // Phương thức AreEqual:
            // Tham số 1: Kết quả mong đợi
            // Tham số 2: Kết quả thực tế
            // Tham số 3: Tin nhắn khi có lỗi
            Assert.AreEqual("Không phải tam giác", _t.classifyTriangle(), "Hiển thị không phải tam giác khi có 3 điểm trùng nhau");
        }
        [Test]
        public void TwoPointsOverlapEachOther()
        {
            _t = new Triangle(new Point(0, 0), new Point(0, 0), new Point(1, 1));
            Assert.AreEqual("Không phải tam giác", _t.classifyTriangle(), "Hiển thị không phải tam giác khi có 2 điểm trùng nhau");
        }
        [Test]
        public void ThreeCollinearPoints()
        {
            _t = new Triangle(new Point(0, 0), new Point(1, 1), new Point(2, 2));
            Assert.AreEqual("Không phải tam giác", _t.classifyTriangle(), "Hiển thị không phải tam giác khi có 3 điểm thẳng hàng");
        }
        [Test]
        public void CoordinateHasInvalidInput()
        {
            _t = new Triangle(new Point('x', 0), new Point(0, 0), new Point(2, 2));
            Assert.AreEqual("Không phải tam giác", _t.classifyTriangle(), "Hiển thị không phải tam giác khi có tọa độ là kí tự");
        }
        [Test]
        public void DisplayEquilateralTriangle()
        {
            _t = new Triangle(new Point(0, 0), new Point(2, 0), new Point(1, Math.Sqrt(3)));
            Assert.AreEqual("Tam giác đều", _t.classifyTriangle(), "Hiển thị tam giác đều khi 3 điểm tạo thành 3 cạnh bằng nhau");
        }
        
        [Test]
        public void DisplayRightAndIsoscelesTriangle()
        {
            _t = new Triangle(new Point(0, 0), new Point(2, 0), new Point(0, 2));
            Assert.AreEqual("Tam giác vuông cân", _t.classifyTriangle(), "Hiển thị tam giác vuông cân khi 3 điểm tạo thành 3 cạnh trong đó có 2 cạnh vuông góc và bằng nhau");
        }
        [Test]
        public void DisplayIsoscelesTriangle()
        {
            _t = new Triangle(new Point(0, 0), new Point(2, 0), new Point(1, 1.74));
            Assert.AreEqual("Tam giác cân", _t.classifyTriangle(), "Hiển thị tam giác cân khi 3 điểm tạo thành 3 cạnh trong đó chỉ có 2 cạnh bằng nhau");
        }
        [Test]
        public void DisplayRightTriangle()
        {
            _t = new Triangle(new Point(0, 0), new Point(2, 0), new Point(0, 1));
            Assert.AreEqual("Tam giác vuông", _t.classifyTriangle(), "Hiển thị tam giác vuông cân khi 3 điểm tạo thành 3 cạnh trong đó có 2 cạnh vuông góc và không bằng nhau");
        }
        [Test]
        public void DisplayNormalTriangle()
        {
            _t = new Triangle(new Point(0, 0), new Point(17, 5), new Point(19, 2));
            Assert.AreEqual("Tam giác thường", _t.classifyTriangle(), "Hiển thị tam giác thường khi 3 điểm tạo thành 3 cạnh không có tính chất gì đặc biệt");
        }
        [Test]
        public void CalculateTrianglePerimeter()
        {
            _t = new Triangle(new Point(0, 0), new Point(17, 5), new Point(19, 2));
            Assert.AreEqual(Math.Sqrt(314) + Math.Sqrt(365) + Math.Sqrt(13), _t.calPerimeter(), "Tính chu vi tam giác");
        }
    }
}
