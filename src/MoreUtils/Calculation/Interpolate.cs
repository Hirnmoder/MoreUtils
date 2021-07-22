using System;

namespace MoreUtils.Calculation
{
    public static class Interpolate
    {
        /// <summary>
        /// Interpolate between <paramref name="from"/> and <paramref name="to"/>
        /// using linear interpolation.
        /// </summary>
        /// <param name="from">The from value.</param>
        /// <param name="to">The to value.</param>
        /// <param name="progress">The progress value used for interpolation.</param>
        /// <returns>The interpolated value.</returns>
        public static double Linear(double from, double to, double progress)
            => from + progress * (to - from);

        /// <summary>
        /// Interpolate between <paramref name="from"/> and <paramref name="to"/>
        /// using linear interpolation. This function clamps the returned value
        /// to the inclusive range of <paramref name="from"/> and <paramref name="to"/>.
        /// </summary>
        /// <inheritdoc cref="Linear(double, double, double)"/>
        public static double LinearClamp(double from, double to, double progress)
            => Interpolate.Linear(from, to, Math.Clamp(progress, 0.0, 1.0));


        /// <summary>
        /// Interpolate between <paramref name="from"/> and <paramref name="to"/>
        /// using smooth interpolation based on sine wave.
        /// </summary>
        /// <inheritdoc cref="Linear(double, double, double)"/>
        public static double Smooth(double from, double to, double progress)
            => from + (1 - (Math.Cos(progress * Math.PI) + 1.0) / 2.0) * (to - from);

        /// <summary>
        /// Interpolate between <paramref name="from"/> and <paramref name="to"/>
        /// using smooth interpolation based on sine wave. This function clamps
        /// the <paramref name="progress"/> value to the inclusive range of
        /// 0.0 and 1.0 to avoid undesired behavior when using values outside
        /// that range.
        /// </summary>
        /// <inheritdoc cref="Smooth(double, double, double)"/>
        public static double SmoothClamp(double from, double to, double progress)
            => Interpolate.Smooth(from, to, Math.Clamp(progress, 0.0, 1.0));
    }
}
