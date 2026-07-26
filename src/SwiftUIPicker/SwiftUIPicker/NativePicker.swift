//
//  NativePicker.swift
//  SwiftUIPicker
//
//  Created by Prateek Mahendrakar on 7/20/26.
//

import SwiftUI

public struct NativePicker: View {
    // MARK: - Properties

    let items: [String]
    let title: String
    let style: NativePickerStyle
    @Binding var selectedItem: String

    // MARK: - Init

    public init(title: String,
                items: [String],
                selectedItem: Binding<String>,
                style: NativePickerStyle) {
        self.items = items
        self.title = title
        self.style = style
        _selectedItem = selectedItem
    }

    // MARK: - Template

    var pickerContent: some View {
        Picker(title, selection: $selectedItem) {
            ForEach(items, id: \.self) { Text($0) }
        }
    }

    public var body: some View {
        switch style {
        case .segmented: pickerContent.pickerStyle(.segmented)
        case .inline: pickerContent.pickerStyle(.inline)
        case .menu: pickerContent.pickerStyle(.menu)
        case .wheel: pickerContent.pickerStyle(.wheel)
        case .palette:
            if #available(iOS 17.0, *) {
                pickerContent.pickerStyle(.palette)
            } else {
                pickerContent.pickerStyle(.automatic)
            }
        case .navigationLink:
            if #available(iOS 16.0, *) {
                NavigationStack {
                    pickerContent.pickerStyle(.navigationLink)
                }
            } else {
                pickerContent.pickerStyle(.automatic)
            }
        case .automatic:
            pickerContent.pickerStyle(.automatic)
        }
    }
}

// MARK: - Previews

#Preview {
    Group {
        Text("Segmented")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .segmented)
    }
    Group {
        Text("Inline")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .inline)
    }
    Group {
        Text("Menu")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .menu)
    }
    Group {
        Text("Wheel")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .wheel)
    }
    Group {
        Text("Palette")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .palette)
    }
    Group {
        Text("NavigationLink")
            .font(.caption)
            .foregroundStyle(.secondary)
        NativePicker(title: "Color",
                     items: ["Red", "Green", "Blue"],
                     selectedItem: .constant("Red"),
                     style: .navigationLink)
    }

    .padding()
}
