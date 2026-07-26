//
//  NativePicker.swift
//  SwiftUIPicker
//
//  Created by Prateek Mahendrakar on 7/20/26.
//

import SwiftUI

public struct NativePicker: View {
    let items: [String]
    let title: String
    let style: NativePickerStyle
    @Binding var selectedItem: String

    public init(items: [String], title: String, style: NativePickerStyle, selectedItem: Binding<String>) {
        self.items = items
        self.title = title
        self.style = style
        _selectedItem = selectedItem
    }

    public var body: some View {
        switch style {
        case .segmented: pickerContent.pickerStyle(.segmented)
        case .inline: pickerContent.pickerStyle(.inline)
        case .menu: pickerContent.pickerStyle(.menu)
        case .wheel: pickerContent.pickerStyle(.wheel)
        case .palette, .navigationLink, .automatic: pickerContent.pickerStyle(.automatic)
        }
    }

    var pickerContent: some View {
        Picker(title, selection: $selectedItem) {
            ForEach(items, id: \.self) { Text($0) }
        }
    }
}
