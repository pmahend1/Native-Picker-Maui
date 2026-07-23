//
//  NativePicker.swift
//  SwiftUIPicker
//
//  Created by Prateek Mahendrakar on 7/20/26.
//

import SwiftUI

struct NativePicker: View {
    let items: [String]

    @Binding var selectedItem: String

    var body: some View {
        Picker("Select", selection: $selectedItem) {
            ForEach(items, id: \.self) {
                Text($0)
            }
        }.pickerStyle(.menu)
    }
}
