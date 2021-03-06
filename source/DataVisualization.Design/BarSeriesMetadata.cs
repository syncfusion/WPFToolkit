// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

extern alias Silverlight;
using System.ComponentModel;
using System.Windows.Controls.Design.Common;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.PropertyEditing;
using SSWCDC = Silverlight::System.Windows.Controls.DataVisualization.Charting;

namespace System.Windows.Controls.DataVisualization.Design
{
    /// <summary>
    /// To register design time metadata for SSWCDC.BarSeries.
    /// </summary>
    internal class BarSeriesMetadata : AttributeTableBuilder
    {
        /// <summary>
        /// To register design time metadata for SSWCDC.BarSeries.
        /// </summary>
        public BarSeriesMetadata()
            : base()
        {
            AddCallback(
                typeof(SSWCDC.BarSeries),
                b =>
                {
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.ActualDependentRangeAxis),
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.ActualIndependentAxis),
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.DependentRangeAxis),
                        new CategoryAttribute(Properties.Resources.DataVisualization));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.IndependentAxis),
                        new CategoryAttribute(Properties.Resources.DataVisualization));

                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.DataPointStyle),
                        new CategoryAttribute(Properties.Resources.DataVisualizationStyling));

                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.DependentRangeAxis),
                        new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.IndependentAxis),
                        new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

#if MWD40
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.IndependentAxis),
                        new AlternateContentPropertyAttribute());
                    b.AddCustomAttributes(
                        Extensions.GetMemberName<SSWCDC.BarSeries>(x => x.DependentRangeAxis),
                        new AlternateContentPropertyAttribute());
#endif
                });
        }
    }
}