using System;

namespace SaasOvation.Common
{
    public static class Assert
    {
        public static void ArgumentEquals(Object anObject1, Object anObject2, String aMessage) {
            if (!anObject1.Equals(anObject2)) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentFalse(bool aBoolean, String aMessage) {
            if (aBoolean) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentLength(String aString, int aMaximum, String aMessage) {
            int length = aString.Trim().Length;
            if (length > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentLength(String aString, int aMinimum, int aMaximum, String aMessage) {
            int length = aString.Trim().Length;
            if (length < aMinimum || length > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentNotEmpty(String aString, String aMessage) {
            if (string.IsNullOrWhiteSpace(aString)) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentNotEquals(Object anObject1, Object anObject2, String aMessage) {
            if (anObject1.Equals(anObject2)) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentNotNull(Object anObject, String aMessage) {
            if (anObject == null) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentRange(double aValue, double aMinimum, double aMaximum, String aMessage) {
            if (aValue < aMinimum || aValue > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentRange(float aValue, float aMinimum, float aMaximum, String aMessage) {
            if (aValue < aMinimum || aValue > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentRange(int aValue, int aMinimum, int aMaximum, String aMessage) {
            if (aValue < aMinimum || aValue > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentRange(long aValue, long aMinimum, long aMaximum, String aMessage) {
            if (aValue < aMinimum || aValue > aMaximum) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void ArgumentTrue(bool abool, String aMessage) {
            if (!abool) {
                throw new ArgumentException(aMessage);
            }
        }

        public static void StateFalse(bool abool, String aMessage) {
            if (abool) {
                throw new InvalidOperationException(aMessage);
            }
        }

        public static void StateTrue(bool abool, String aMessage) {
            if (!abool) {
                throw new InvalidOperationException(aMessage);
            }
        }
    }
}