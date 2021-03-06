﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Flexor.Tests
{
    [TestClass]
    public class FluentResizableShould
    {
        private IResizable underTest;

        [TestMethod]
        public void Constructor_Default_Default()
        {
            // Arrange
            this.underTest = new FluentResizable();

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-unset")));
        }

        [TestMethod]
        public void GetClass_Auto_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Auto;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-auto")));
        }

        [TestMethod]
        public void GetClass_Grow_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Grow;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-grow")));
        }

        [TestMethod]
        public void GetClass_Initial_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Initial;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-initial")));
        }

        [TestMethod]
        public void GetClass_NoGrow_Correctly()
        {
            // Arrange
            this.underTest = Resizable.NoGrow;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-nogrow")));
        }

        [TestMethod]
        public void GetClass_NoShrink_Correctly()
        {
            // Arrange
            this.underTest = Resizable.NoShrink;

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .Match(x => x.All(v => v.StartsWith("flex-resize") && v.EndsWith("-noshrink")));
        }

        [TestMethod]
        public void OnMobile_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnMobile(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow");
        }

        [TestMethod]
        public void OnMobileAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnMobileAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTablet_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTablet(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow");
        }

        [TestMethod]
        public void OnTabletAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTabletAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTabletAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTabletAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow");
        }

        [TestMethod]
        public void OnDesktop_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktop(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktopAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktopAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow");
        }

        [TestMethod]
        public void OnWidescreen_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreen(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreenAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreenAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow");
        }

        [TestMethod]
        public void OnFullHD_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnFullHD(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_SetsValue_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnFullHDAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }



        [TestMethod]
        public void OnMobile_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnMobile(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnMobileAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnMobileAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTablet_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTablet(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnTabletAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTabletAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnTabletAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnTabletAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnDesktop_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktop(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnDesktopAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktopAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnDesktopAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnDesktopAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnWidescreen_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreen(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnWidescreenAndLarger_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreenAndLarger(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnWidescreenAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnWidescreenAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-unset");
        }

        [TestMethod]
        public void OnFullHD_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnFullHD(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-unset")
                .And
                .HaveElementAt(1, "flex-resize-sm-unset")
                .And
                .HaveElementAt(2, "flex-resize-md-unset")
                .And
                .HaveElementAt(3, "flex-resize-lg-unset")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

        [TestMethod]
        public void OnFullHDAndSmaller_LeavesDefault_Correctly()
        {
            // Arrange
            this.underTest = Resizable.Is.OnFullHDAndSmaller(ResizableOption.NoGrow);

            // Act
            var underTestClass = underTest.Class;

            // Assert
            underTestClass.Should().NotBeNullOrWhiteSpace();

            underTestClass.Split(' ').Should()
                .HaveCount(5)
                .And
                .OnlyHaveUniqueItems()
                .And
                .HaveElementAt(0, "flex-resize-nogrow")
                .And
                .HaveElementAt(1, "flex-resize-sm-nogrow")
                .And
                .HaveElementAt(2, "flex-resize-md-nogrow")
                .And
                .HaveElementAt(3, "flex-resize-lg-nogrow")
                .And
                .HaveElementAt(4, "flex-resize-xl-nogrow");
        }

    }
}
