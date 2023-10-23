using System;

namespace LB_1 {
    public class Triangle {
        private readonly float _a, _b, _c;

        private float Find_A(float angle) {
            return (float)Math.Sqrt(Math.Pow(_b, 2) + Math.Pow(_c, 2) - (2 * _b * _c * Math.Cos(angle)));
        }

        public Triangle(bool isAngleA, float a, float b, float c) {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона трикутника не може бути менше 0!");
            if (isAngleA) {
                if (a <= 0 || a >= 180)
                    throw new Exception("Кут неправильний!");
                this._b = b;
                this._c = c;
                this._a = Find_A(a);
                return;
            }

            this._a = a;
            this._b = b;
            this._c = c;
        }

        private float P2() {
            return P() / 2;
        }

        public float P() {
            return (float)_a + _b + _c;
        }

        public float S() {
            return (float)Math.Sqrt(P2() * (P2() - _a) * (P2() - _b) * (P2() - _c));
        }
    }
}