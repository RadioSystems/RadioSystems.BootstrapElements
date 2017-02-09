using System;

namespace RadioSystems.BootstrapElements.Services {
    public static class HtmlIdGenerator {
        public static string Generate() {
            return Guid.NewGuid().GetHashCode().ToString();
        }
    }
}